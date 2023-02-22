using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MvcCSharp6.Models;

namespace MvcCSharp6.Controllers
{
    public class HomeController : Controller
    {
        private MovieDataContext mdContext { get; set; }

        public HomeController(MovieDataContext movieData)
        {
            mdContext = movieData;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = mdContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(MovieModel model)
        {
            if (ModelState.IsValid)
            {
                mdContext.Add(model);
                mdContext.SaveChanges();
                return RedirectToAction("MovieList");
            } // if invalid input
            else return RedirectToAction("Add");
        }

        public IActionResult MovieList()
        {
            var movies = mdContext.Responses
            .Include(x => x.category)
            .OrderBy(x => x.title)
            .ToList();

            return View(movies);
        }
        
        [HttpGet]
        public IActionResult Edit(int movieId)
        {
            ViewBag.Categories = mdContext.Categories.ToList();
            var movie = mdContext.Responses.Single(x => x.movieId == movieId);

            return View("Add", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieModel model)
        {
            if (ModelState.IsValid)
            {
                mdContext.Update(model);
                mdContext.SaveChanges();
                return RedirectToAction("MovieList");
            } // if invalid input
            else return RedirectToAction("Edit", model.movieId);
        }

        [HttpGet]
        public IActionResult Delete(int movieId)
        {
            var movie = mdContext.Responses.Single(x => x.movieId == movieId);
            return View(movie);
        }
        
        [HttpPost]
        public IActionResult Delete(MovieModel model)
        {
            mdContext.Responses.Remove(model);
            mdContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}

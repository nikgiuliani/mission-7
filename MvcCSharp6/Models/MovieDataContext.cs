using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCSharp6.Models
{
    // Context for database
    public class MovieDataContext : DbContext
    {
        // constructor
        public MovieDataContext(DbContextOptions<MovieDataContext> options) : base (options)
        {

        }

        public DbSet<MovieModel> Responses { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<CategoryModel>().HasData(
                new CategoryModel { categoryId = 1, categoryName = "comedy" },
                new CategoryModel { categoryId = 2, categoryName = "drama" },
                new CategoryModel { categoryId = 3, categoryName = "action/adventure" },
                new CategoryModel { categoryId = 4, categoryName = "romance" },
                new CategoryModel { categoryId = 5, categoryName = "historical fiction" },
                new CategoryModel { categoryId = 6, categoryName = "history" },
                new CategoryModel { categoryId = 7, categoryName = "documentary" }
            );

            mb.Entity<MovieModel>().HasData(
                new MovieModel
                {
                    movieId = 1,
                    categoryId = 1,
                    title = "Cars 2",
                    year = 2011,
                    director = "John Lasseter",
                    rating = "G",
                    notes = "super emotional"
                },
                new MovieModel
                {
                    movieId = 2,
                    categoryId = 2,
                    title = "Megamind",
                    year = 2010,
                    director = "Tom McGrath",
                    rating = "PG",
                    notes = "greatest movie ever made"
                },
                new MovieModel
                {
                    movieId = 3,
                    categoryId = 5,
                    title = "Saving Private Ryan",
                    year = 1998,
                    director = "Steven Spielberg",
                    rating = "R",
                    notes = "wow"
                }
            );
        }
    }
}
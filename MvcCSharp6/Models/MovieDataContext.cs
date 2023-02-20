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

        public DbSet<MovieModel> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieModel>().HasData(
                new MovieModel
                {
                    movieId = 1,
                    category = "drama",
                    title = "Cars 2",
                    year = 2011,
                    director = "John Lasseter",
                    rating = "G",
                    notes = "super emotional"
                },
                new MovieModel
                {
                    movieId = 2,
                    category = "comedy",
                    title = "Megamind",
                    year = 2010,
                    director = "Tom McGrath",
                    rating = "PG",
                    notes = "greatest movie ever made"
                },
                new MovieModel
                {
                    movieId = 3,
                    category = "action",
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
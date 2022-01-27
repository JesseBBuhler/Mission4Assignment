using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext (DbContextOptions<MovieCollectionContext> options) : base (options)
            {

            }

        public DbSet<MovieCollectionForm> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieCollectionForm>().HasData(
                new MovieCollectionForm
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "Avengers: Infinity War",
                    Year = 2018,
                    Director = "The Russo Brothers",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieCollectionForm
                {
                    MovieID = 2,
                    Category = "Action/Adventure",
                    Title = "Nausicaa of the Valley of the Wind",
                    Year = 1984,
                    Director = "Hayao Miyazaki",
                    Rating = "PG-13",
                    Edited = false, // "No Cuts!!!"
                    LentTo = "Hailey",
                    Notes = "The book is even better"
                },
                new MovieCollectionForm
                {
                    MovieID = 3,
                    Category = "Action/Adventure",
                    Title = "Lord of the Rings: The Two Towers",
                    Year = 2002,
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "",
                    Notes = "My Precious!!!"
                }

            );
        }
    }
}

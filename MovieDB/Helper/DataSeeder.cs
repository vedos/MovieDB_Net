using MovieDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieDB.Helper
{
    public class DataSeeder
    {
        public static void SeedMovies(MovieContext context)
        {
            if (!context.Movies.Any())
            {
                var movies = new List<Movie>
                {
                    new Movie { Title = "The Matrix",
                   Description= "When a beautiful stranger leads computer hacker Neo to a forbidding underworld," +
                   " he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", ReleaseDate=new DateTime(1999,3,24) },

                    new Movie { Title = "A Prophet", Description ="A young Algerian man is sent to a French prison.", ReleaseDate=new DateTime(2009,5,16) },

                    new Movie { Title = "The Godfather", Description="An organized crime dynasty's aging patriarch transfers control" +
                    " of his clandestine empire to his reluctant son.", ReleaseDate= new DateTime(1972,3,14) },
                    
                    new Movie { Title = "300", Description="King Leonidas of Sparta and a force of" +
                    " 300 men fight the Persians at Thermopylae in 480 B.C.", ReleaseDate= new DateTime(2006,12,9) },
                    
                    new Movie { Title = "Casino Royale", Description="After earning 00 status and a licence to kill, Secret Agent " +
                    "James Bond sets out on his first mission as 007. " +
                    "Bond must defeat a private banker funding terrorists in a high-stakes game of poker at Casino Royale, Montenegro.", ReleaseDate= new DateTime(2006,11,14) }


                };
                context.AddRange(movies);
                context.SaveChanges();
            }
        }
    }
}

using MovieDB.Models;
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
                new Movie { Title = "Afghanistan" },
                new Movie { Title = "Albania" },
                new Movie { Title = "Algeria" },
                new Movie { Title = "Andorra" },
                new Movie { Title = "Angola" },
                new Movie { Title = "Antigua and Barbuda" },
                new Movie { Title = "Argentina" },
                new Movie { Title = "Armenia" },
                new Movie { Title = "Aruba" },
                new Movie { Title = "Australia" },
                new Movie { Title = "Austria" },
                new Movie { Title = "Azerbaijan" }
            };
                context.AddRange(movies);
                context.SaveChanges();
            }
        }
    }
}

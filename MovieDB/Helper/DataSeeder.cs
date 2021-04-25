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
            if (context.Movies.Any())
            {
                context.Movies.RemoveRange(context.Movies.ToList());
                context.SaveChanges();
            }
            if (!context.Movies.Any())
            {
                var movies = new List<Movie>
                {
                    new Movie { Title = "The Matrix",
                    Description= "When a beautiful stranger leads computer hacker Neo to a forbidding underworld," +
                    " he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.", ReleaseDate=new DateTime(1999,3,24),
                        ImageUrl="https://lh4.googleusercontent.com/kIcbzlKGRcRSdpsAsiG4egup_sW9H-45zB_P9wvmgvgPXigcQaoXoAv9mITSgUlHFJJbZ9tkOVYkAQ=w1920-h969-rw",
                        CategoryId=context.Categories.Where(x=>x.Name == "Movie").Single().Id
                    },

                    new Movie { Title = "A Prophet", Description ="A young Algerian man is sent to a French prison.", ReleaseDate=new DateTime(2009,5,16),
                        ImageUrl="https://lh3.googleusercontent.com/FGciM-WHJFq4yrM5fOHO62NzA7FMvfs1ppL6ocXtPjI3X7LW7eyGfSEWI1HxbDgPeEiSX8hk_E5yQA=w1920-h969", CategoryId=context.Categories.Where(x=>x.Name == "Movie").Single().Id },

                    new Movie { Title = "The Godfather", Description="An organized crime dynasty's aging patriarch transfers control" +
                    " of his clandestine empire to his reluctant son.", ReleaseDate= new DateTime(1972,3,14),
                        ImageUrl ="https://lh6.googleusercontent.com/sB-tztN5lNNkRMFVkjOjm0xeePe7VOucDiUSjIr5V925uoDhyKeOmn6hBB8BnYK01k1rNzzRHpTe0Q=w1920-h969", CategoryId=context.Categories.Where(x=>x.Name == "Movie").Single().Id },

                    new Movie { Title = "300", Description="King Leonidas of Sparta and a force of" +
                    " 300 men fight the Persians at Thermopylae in 480 B.C.", ReleaseDate= new DateTime(2006,12,9),
                        ImageUrl="https://lh4.googleusercontent.com/nqZTJ7SYHm0vJStapGzG4HTD4RnIOMaqAhpL-90hiQ_d4q13Mi2GnCiIkzRthRAxTPC4UesJuPIBBw=w1920-h969-rw", CategoryId=context.Categories.Where(x=>x.Name == "Movie").Single().Id },

                    new Movie { Title = "Casino Royale", Description="After earning 00 status and a licence to kill, Secret Agent " +
                    "James Bond sets out on his first mission as 007. " +
                    "Bond must defeat a private banker funding terrorists in a high-stakes game of poker at Casino Royale, Montenegro.", ReleaseDate= new DateTime(2006,11,14),
                        ImageUrl="https://drive.google.com/file/d/1OWv6fA1_gILm04UFmoA-mljjghnPsp7g/view?usp=sharing", CategoryId=context.Categories.Where(x=>x.Name == "Movie").Single().Id }


                };
                context.AddRange(movies);
                context.SaveChanges();
            }
        }

        public static void SeedCategories(MovieContext context)
        {
            if (context.Categories.Any())
            {
                context.Categories.RemoveRange(context.Categories.ToList());
                context.SaveChanges();
            }
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category {Name="TV Show" }, new Category {Name="Movie"}
                };
            }

        }
    }
}

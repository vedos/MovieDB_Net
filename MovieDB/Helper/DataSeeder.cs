using MovieDB.Models;
using MovieDB.Models.Enums;
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
                        ImageUrl="https://flxt.tmsimg.com/assets/p22804_p_v10_ab.jpg",
                        CategoryId=context.Categories.Where(x=>x.Name ==ShowType.MOVIE.ToDescriptionString()).Single().Id
                    },

                    new Movie { Title = "A Prophet", Description ="A young Algerian man is sent to a French prison.", ReleaseDate=new DateTime(2009,5,16),
                        ImageUrl="https://upload.wikimedia.org/wikipedia/en/d/d1/A_Prophet.jpg", CategoryId=context.Categories.Where(x=>x.Name == ShowType.MOVIE.ToDescriptionString()).Single().Id },

                    new Movie { Title = "The Godfather", Description="An organized crime dynasty's aging patriarch transfers control" +
                    " of his clandestine empire to his reluctant son.", ReleaseDate= new DateTime(1972,3,14),
                        ImageUrl ="https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_UY1200_CR107,0,630,1200_AL_.jpg", CategoryId=context.Categories.Where(x=>x.Name == ShowType.MOVIE.ToDescriptionString()).Single().Id },

                    new Movie { Title = "300", Description="King Leonidas of Sparta and a force of" +
                    " 300 men fight the Persians at Thermopylae in 480 B.C.", ReleaseDate= new DateTime(2006,12,9),
                        ImageUrl="https://flxt.tmsimg.com/assets/p163191_p_v10_an.jpg", CategoryId=context.Categories.Where(x=>x.Name == "Movie").Single().Id },

                    new Movie { Title = "Casino Royale", Description="After earning 00 status and a licence to kill, Secret Agent " +
                    "James Bond sets out on his first mission as 007. " +
                    "Bond must defeat a private banker funding terrorists in a high-stakes game of poker at Casino Royale, Montenegro.", ReleaseDate= new DateTime(2006,11,14),
                        ImageUrl="https://m.media-amazon.com/images/M/MV5BMDI5ZWJhOWItYTlhOC00YWNhLTlkNzctNDU5YTI1M2E1MWZhXkEyXkFqcGdeQXVyNTIzOTk5ODM@._V1_.jpg",
                        CategoryId=context.Categories.Where(x=>x.Name ==ShowType.MOVIE.ToDescriptionString()).Single().Id },

                   new Movie { Title = "Deadpool 2", Description="After losing Vanessa (Morena Baccarin), the love of his life," +
                   " 4th-wall breaking mercenary Wade Wilson aka Deadpool (Ryan Reynolds) must assemble a team and protect a young, full-figured mutant" +
                   " Russell Collins aka Firefist (Julian Dennison) from Cable (Josh Brolin), a no-nonsense, dangerous cyborg from the future, and must " +
                   "also learn the most important lesson of all: to be part of a family again.", ReleaseDate= new DateTime(2018,7,2),
                        ImageUrl="https://img.yts.mx/assets/images/movies/deadpool_2_2018/medium-cover.jpg",
                       CategoryId=context.Categories.Where(x=>x.Name == ShowType.MOVIE.ToDescriptionString()).Single().Id },

                    new Movie { Title = "Mortal Kombat", Description="Washed-up MMA fighter Cole Young, unaware of his heritage, and hunted by Emperor " +
                      "Shang Tsung's best warrior, Sub-Zero, seeks out and trains with Earth's greatest champions as he prepares to stand against" +
                      " the enemies of Outworld in a high stakes battle for the universe.", ReleaseDate= new DateTime(2021,8,9),
                        ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/2xmx8oPlbDaxTjHsIOZvOt5L3aJ.jpg",
                       CategoryId=context.Categories.Where(x=>x.Name == ShowType.MOVIE.ToDescriptionString()).Single().Id },

                    new Movie { Title = "Cherry", Description="", ReleaseDate= new DateTime(2021,2,26),
                        ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/pwDvkDyaHEU9V7cApQhbcSJMG1w.jpg",
                       CategoryId=context.Categories.Where(x=>x.Name == ShowType.MOVIE.ToDescriptionString()).Single().Id },

                                        new Movie { Title = "Raya and the Last Dragon", Description="Raya and the Last Dragon", ReleaseDate= new DateTime(2021,1,1),
                        ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/lPsD10PP4rgUGiGR4CCXA6iY0QQ.jpg",
                       CategoryId=context.Categories.Where(x=>x.Name == ShowType.MOVIE.ToDescriptionString()).Single().Id },

                                        new Movie { Title = "The Marksman", Description="", ReleaseDate= new DateTime(2021,2,26),
                        ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/6vcDalR50RWa309vBH1NLmG2rjQ.jpg",
                       CategoryId=context.Categories.Where(x=>x.Name == ShowType.MOVIE.ToDescriptionString()).Single().Id },

                                            new Movie { Title = "Twist", Description="", ReleaseDate= new DateTime(2021,2,26),
                        ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/29dCusd9PwHrbDqzxNG35WcpZpS.jpg",
                       CategoryId=context.Categories.Where(x=>x.Name == ShowType.MOVIE.ToDescriptionString()).Single().Id },



                   new Movie { Title = "The Walking Dead", Description="Sheriff Deputy Rick Grimes wakes up from a coma to learn " +
                   "the world is in ruins and must lead a group of survivors to stay alive.", ReleaseDate= new DateTime(2010,10,31),
                        ImageUrl="https://m.media-amazon.com/images/M/MV5BMTc5ZmM0OTQtNDY4MS00ZjMyLTgwYzgtOGY0Y2VlMWFmNDU0XkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_.jpg",
                       CategoryId=context.Categories.Where(x=>x.Name == ShowType.TVSHOW.ToDescriptionString()).Single().Id },

                   new Movie { Title = "Narcos", Description="A gritty chronicle of the war against Colombia's infamously violent and powerful drug cartels.",
                       ReleaseDate= new DateTime(2015,10,31),
                        ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/rTmal9fDbwh5F0waol2hq35U4ah.jpg",
                       CategoryId=context.Categories.Where(x=>x.Name == ShowType.TVSHOW.ToDescriptionString()).Single().Id },


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
                    new Category {Name= ShowType.TVSHOW.ToDescriptionString() }, new Category {Name=ShowType.MOVIE.ToDescriptionString()}
                };


                context.AddRange(categories);
                context.SaveChanges();
            }
        }
    }
}

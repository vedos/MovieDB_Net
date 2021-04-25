using MovieDB.Models;
using MovieDB.Models.Enums;
using MovieDB.Models.Out;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace MovieDB.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context;
        public MovieRepository(MovieContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _context.Movies.Select(n => new Movie
            {
                Description = n.Description,
                Id = n.Id,
                ImageUrl = n.ImageUrl,
                Title = n.Title
            }).ToList();
        }

        public IPagedList<MovieOut> GetTopRatedMovies(string search, int take, int? page)
        {
            return _context.Movies
                .Where(x => x.Category.Name == ShowType.MOVIE.ToDescriptionString() && (x.Title.ToLower().Contains(search.ToLower()) ||
                    x.Description.ToLower().Contains(search.ToLower()) ||
                    x.Category.Name.ToLower().Contains(search.ToLower())
                ))
                .Select(n => new MovieOut
                {
                    Description = n.Description,
                    Id = n.Id,
                    ImageUrl = n.ImageUrl,
                    Title = n.Title,
                    ReleaseDate = n.ReleaseDate,
                    Category = n.Category.Name,
                    Rating = _context.Ratings.Where(y => y.MovieId == n.Id).Any() ? _context.Ratings.Where(y => y.MovieId == n.Id).Select(y => y.Value).Average() : 0,
                    Actors = _context.Actors.Where(y => y.Movies.Where(m => m.Id == n.Id).Any()).ToList()
                })
                .OrderByDescending(x => _context.Ratings.Where(y => y.MovieId == x.Id).Select(y => y.Value).Average())
                .ToPagedList(page ?? 1, take);
        }

        public IPagedList<MovieOut> GetTopRatedTVShows(string search, int take, int? page)
        {
            return _context.Movies
                .Where(x => x.Category.Name == ShowType.TVSHOW.ToDescriptionString() && (x.Title.ToLower().Contains(search.ToLower()) ||
                x.Description.ToLower().Contains(search.ToLower()) ||
                x.Category.Name.ToLower().Contains(search.ToLower())
                ))
                .Select(n => new MovieOut
                {
                    Description = n.Description,
                    Id = n.Id,
                    ImageUrl = n.ImageUrl,
                    Title = n.Title,
                    ReleaseDate = n.ReleaseDate,
                    Category = n.Category.Name,
                    Rating = _context.Ratings.Where(y => y.MovieId == n.Id).Any() ? _context.Ratings.Where(y => y.MovieId == n.Id).Select(y => y.Value).Average() : 0,
                    Actors = _context.Actors.Where(y => y.Movies.Where(m => m.Id == n.Id).Any()).ToList()
                })
                .OrderByDescending(x => _context.Ratings.Where(y => y.MovieId == x.Id).Select(y => y.Value).Average())
                .ToPagedList(page ?? 1, take);
        }
    }
}

using MovieDB.Models;
using System.Collections.Generic;
using System.Linq;

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

    }
}

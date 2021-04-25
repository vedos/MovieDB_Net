using MovieDB.Models;
using System.Collections.Generic;

namespace MovieDB.Repositories
{
    public interface IMovieRepository
    {
        public IEnumerable<Movie>GetAllMovies();

        public IEnumerable<Movie> GetTopRatedMovies(string search, string take);

        public IEnumerable<Movie> GetTopRatedTVShows(string search, string take);
    }
}

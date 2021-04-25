using MovieDB.Models;
using MovieDB.Models.Out;
using System.Collections.Generic;
using X.PagedList;

namespace MovieDB.Repositories
{
    public interface IMovieRepository
    {
        public IEnumerable<Movie>GetAllMovies();

        public IPagedList<MovieOut> GetTopRatedMovies(string search, int take, int? page);

        public IPagedList<MovieOut> GetTopRatedTVShows(string search, int take, int? page);
    }
}

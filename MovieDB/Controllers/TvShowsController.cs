using Microsoft.AspNetCore.Mvc;
using MovieDB.Models.Out;
using MovieDB.Repositories;
using System.Collections.Generic;

namespace MovieDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvShowsController : ControllerBase
    {

        private readonly IMovieRepository _moviesRepository;

        public TvShowsController(IMovieRepository movieRepository)
        {
            _moviesRepository = movieRepository;
        }

        [HttpGet]
        public IEnumerable<MovieOut> Get(string search, int take, int page)
        {
            return _moviesRepository.GetTopRatedTVShows(search ?? "", take == 0 ? 10 : take, page == 0 ? 1 : page);
        }
    }
}
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MovieDB.Models.Out;
using MovieDB.Repositories;
using X.PagedList;

namespace MovieDB.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly IMovieRepository _moviesRepository;

        public MovieController(IMovieRepository movieRepository) {
            _moviesRepository = movieRepository;
        }

        [HttpGet]
        public IPagedList<MovieOut> Get(string search,int take, int page)
        {
            return _moviesRepository.GetTopRatedMovies(search ?? "", take == 0 ? 10 : take, page == 0 ? 1 : page); 
        }
    }
}
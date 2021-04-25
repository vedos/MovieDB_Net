using Microsoft.AspNetCore.Mvc;
using MovieDB.Models;
using MovieDB.Repositories;
using System.Collections.Generic;

namespace MovieDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly IMovieRepository _moviesRepository;

        public MovieController(IMovieRepository movieRepository) {
            _moviesRepository = movieRepository;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {         
            return _moviesRepository.GetAllMovies();
        }

    }
}
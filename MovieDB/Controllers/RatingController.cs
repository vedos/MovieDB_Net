using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MovieDB.Models.In;
using MovieDB.Repositories;

namespace MovieDB.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {

        private readonly IRatingRepository _ratingRepository;

        public RatingController(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        [HttpPost]
        public ActionResult PostRating([FromForm] RatingIn rating)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _ratingRepository.Rate(rating);

            return Ok();
        }
    }
}
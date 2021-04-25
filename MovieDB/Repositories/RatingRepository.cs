using MovieDB.Models;
using MovieDB.Models.In;

namespace MovieDB.Repositories
{
    public class RatingRepository : IRatingRepository
    {
            
        private readonly MovieContext _context;
        public RatingRepository(MovieContext context)
        {
            _context = context;
        }

        public void Rate(RatingIn rating)
        {
            Rating r = new Rating();
            r.Value = rating.Rate;
            r.MovieId = rating.MovieId;
            _context.Ratings.Add(r);
            _context.SaveChanges();
        }
    }
}

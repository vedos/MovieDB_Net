using MovieDB.Models.In;

namespace MovieDB.Repositories
{
    public interface IRatingRepository
    {
        public void Rate(RatingIn rating);
    }
}

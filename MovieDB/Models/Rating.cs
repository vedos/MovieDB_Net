using MovieDB.Helper;

namespace MovieDB.Models
{
    public class Rating : IEntity
    {
        public int Id { get; set; }

        public int Value { get; set; }

        public Movie Movie { get; set; }

        public int MovieId { get; set; }

        public User User { get; set; }

        public int? UserId { get; set; }

    }
}

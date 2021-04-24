using MovieDB.Helper;

namespace MovieDB.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }
    }
}

using MovieDB.Helper;

namespace MovieDB.Models
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}

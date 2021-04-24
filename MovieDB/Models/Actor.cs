using MovieDB.Helper;
using System.Collections.Generic;

namespace MovieDB.Models
{
    public class Actor : IEntity
    {
        public Actor()
        {
            this.Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public string BirthDate { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

    }
}

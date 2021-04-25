using MovieDB.Helper;
using System;
using System.Collections.Generic;

namespace MovieDB.Models
{
    public class Movie : IEntity
    {

        public Movie()
        {
            this.Actors = new HashSet<Actor>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

    }
}

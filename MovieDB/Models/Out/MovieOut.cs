﻿using System;
using System.Collections.Generic;

namespace MovieDB.Models.Out
{
    public class MovieOut
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Rating { get; set; }

        public string Category { get; set; }

        public List<Actor>? Actors { get;set; }

    }
}

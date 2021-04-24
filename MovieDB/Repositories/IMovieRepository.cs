﻿using MovieDB.Models;
using System.Collections.Generic;

namespace MovieDB.Repositories
{
    public interface IMovieRepository
    {
        public IEnumerable<Movie>GetAllMovies();
    }
}

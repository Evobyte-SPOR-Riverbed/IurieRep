using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovieApp.Data
{
    public class MvcMovieAppContext : DbContext
    {
        public MvcMovieAppContext (DbContextOptions<MvcMovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}

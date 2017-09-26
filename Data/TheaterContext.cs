using Microsoft.EntityFrameworkCore;
using web_theater.Models;

namespace web_theater
{
    public class TheaterContext : DbContext
    {
        public DbSet<Movie> Movies {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./MVCLibrary.db");
        }
    }
}
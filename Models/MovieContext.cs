using Microsoft.EntityFrameworkCore;

namespace chpt4x1.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options) 
        { } 

        public DbSet<Movie> Movies { get; set; }    

    }
}

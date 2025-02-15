using Microsoft.EntityFrameworkCore;

namespace Mission6_Stuart.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options) 
        {
        }

        public DbSet<Collection> Collections { get; set; }
    }
}

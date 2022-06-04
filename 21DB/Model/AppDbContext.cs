using Microsoft.EntityFrameworkCore;

namespace _21DB.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}

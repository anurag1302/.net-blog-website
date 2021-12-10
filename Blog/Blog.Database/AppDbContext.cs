using Blog.Database.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blog.Database
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using BackendProject.Models;

namespace BackendProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; } // Add this line
    }
}

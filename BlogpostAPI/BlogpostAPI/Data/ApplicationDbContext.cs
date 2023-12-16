using BlogpostAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogpostAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Blogpost> Blogposts { get; set; }
       public DbSet<Category> Categories { get; set; }
    }
}

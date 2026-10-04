using Microsoft.EntityFrameworkCore;
using MyBlog.Models;

namespace  MyBlog.Data.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
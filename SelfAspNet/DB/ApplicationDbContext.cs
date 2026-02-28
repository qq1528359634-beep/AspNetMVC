using Microsoft.EntityFrameworkCore;
using SelfAspNet_MVC.Models;

namespace SelfAspNet_MVC.DB
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<Book> Books { get; set; }
    }
}

using BuklyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BuklyWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
       public DbSet<Category> Categories { get; set; } 
    }
}

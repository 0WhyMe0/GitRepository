using Microsoft.EntityFrameworkCore;
using Web_1.Models;

namespace Web_1.DataB
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) 
        {
                
        }

        public DbSet<Category> Category { get; set; }
    }
}

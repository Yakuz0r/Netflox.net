using Microsoft.EntityFrameworkCore;
using Netflox.Models;

namespace Netflox.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MainUsers> MainUsers { get; set; }
      
    }
}

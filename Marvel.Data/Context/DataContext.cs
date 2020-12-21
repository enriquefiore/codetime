using Marvel.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Marvel.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Comic> Comics { get; set; }
        public DbSet<Story> Stories { get; set; }

    }
}
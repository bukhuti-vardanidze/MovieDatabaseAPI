using Microsoft.EntityFrameworkCore;
using MovieDatabaseAPI.Models;

namespace MovieDatabaseAPI.Db
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
    }
}

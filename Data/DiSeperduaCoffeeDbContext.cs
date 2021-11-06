using Microsoft.EntityFrameworkCore;
using DiSeperduaCoffee.Models;
using DiSeperduaCoffee.Data;

namespace DiSeperduaCoffee.Data
{
    public class DiSeperduaCoffeeDbContext : DbContext
    {
        public DiSeperduaCoffeeDbContext (DbContextOptions<DiSeperduaCoffeeDbContext> options ) : base(options)
        { }

        public DbSet<Coffee> Coffees { get; set; }
    }
} 
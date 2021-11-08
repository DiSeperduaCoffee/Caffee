using Microsoft.EntityFrameworkCore;
using DiSeperduaCoffe.Models;
using DiSeperduaCoffee.Data;

namespace DiSeperduaCoffee.Data
{
    public class DiSeperduaCoffeeDbContext : DbContext
    {
        public DiSeperduaCoffeeDbContext (DbContextOptions<DiSeperduaCoffeeDbContext> options ) : base(options)
        { }

        private DbSet<Coffee> coffees;
    }
} 
using Microsoft.EntityFrameworkCore;
using RealState.Domian.Model;

namespace RealState.Infrastruture;

  public class ApplicationDbContext : DbContext
    {
        public DbSet<Property> Apartments { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }

using Microsoft.EntityFrameworkCore;
using RealState.Domian.Model.Properties;

namespace RealState.Infrastruture.Data.Repositories.ApplicationDbContexts;

public class ApplicationDbContext : DbContext
{
    public DbSet<Property> Properties { get; set; }

    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}

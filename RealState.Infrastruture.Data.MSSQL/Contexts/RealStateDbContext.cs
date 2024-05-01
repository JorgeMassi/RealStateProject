using Microsoft.EntityFrameworkCore;
using RealState.Domian.Model;

namespace RealState.Infrastruture.Data.Contexts;

public class RealStateDbContext : DbContext
{
    public DbSet<Property> Properties { get; set; }

    public RealStateDbContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(RealStateDbContext).Assembly);

    }
}
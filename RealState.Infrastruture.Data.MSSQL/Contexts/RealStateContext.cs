using Microsoft.EntityFrameworkCore;
using RealState.Domian.Model;

namespace RealState.Infrastruture.Data.Contexts;

public class RealStateContext : DbContext
{
    public DbSet<Property> Properties { get; set; }

    public RealStateContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
       
    }
}
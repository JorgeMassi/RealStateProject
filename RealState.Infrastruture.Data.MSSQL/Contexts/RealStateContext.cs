using Microsoft.EntityFrameworkCore;
using RealState.Domian.Model;

namespace RealState.Infrastruture.Data.MSSQL.Contexts;

public class RealStateContext : DbContext
{
    public DbSet<Property> Properties { get; set; }

    public RealStateContext(DbContextOptions options) : base(options)
    {

    }
}
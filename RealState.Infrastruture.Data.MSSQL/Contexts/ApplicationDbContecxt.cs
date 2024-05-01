using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RealState.Infrastruture.Data.Contexts;

namespace RealState.Infrastruture.Data.MSSQL.Contexts
{
    internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<RealStateDbContext>
    {

        static string? connectionString = null;

        static ApplicationDbContextFactory()
        {
            IConfiguration config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.Development.json", true, true)
               .Build();

            connectionString = config["ConnectionStrings:StringSQL"];
            Console.WriteLine("ConnectionString:" + connectionString);
        }


        public RealStateDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RealStateDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new RealStateDbContext(optionsBuilder.Options);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace RealState.Infrastruture;

 internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {

        static string? connectionString = null;

        static ApplicationDbContextFactory()
        {
            IConfiguration config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.Development.json", true, true)
               .Build();

            connectionString = config["ConnectionStrings:RemedyCS"];
            Console.WriteLine("ConnectionString:" + connectionString);
        }


        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}


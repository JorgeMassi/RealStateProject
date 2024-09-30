using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace RealState.Infrastruture.Data.Repositories.ApplicationDbContexts;

internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{

    static string? connectionString = null;

    static ApplicationDbContextFactory()
    {
        IConfiguration config = new ConfigurationBuilder()
           //.SetBasePath(Directory.GetCurrentDirectory())
           //.AddJsonFile("appsettings.Development.json", true, true)
           //.Build();
           .SetBasePath(Directory.GetParent(".").ToString())
           .AddJsonFile("RealState.API\\appsettings.json", true, true)
            .Build();

        connectionString = config["ConnectionStrings:StringSQL"];
        Console.WriteLine("ConnectionString:" + connectionString);
    }


    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

        optionsBuilder.UseSqlServer(connectionString);

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}


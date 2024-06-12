using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace RealState.Infrastruture;

public static class DependencyContainer
    {
        public static void AddWebApiConfigurations(this IServiceCollection services, IConfiguration config)

        {
            // Services
            services.AddScoped<IPropertyService, PropertyService>();

            // Repos

            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<DbContext, ApplicationDbContext>();



            // Database Config
            services.AddRemedyDatabase(config);
        }

        public static IServiceCollection AddRemedyDatabase(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = config.GetConnectionString("RemedyCS");
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("Remedy.Services.WebApi").MigrationsHistoryTable("__EFMigrationsHistory_Data"));
            });
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // TODO: Seed data
            // if (environment.ToLower() == "development") 
            //    services.AddScoped<DbInitializer>();

            return services;
        }
    }

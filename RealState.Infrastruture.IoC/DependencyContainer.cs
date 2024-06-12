using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealState.Application.Interfaces.Properties;
using RealState.Application.Interfaces.UnitOfWork;
using RealState.Application.Services;
using RealState.Infrastruture.Data;
using RealState.Infrastruture.Data.Repositories;


namespace RealState.Infrastruture.IoC;

public static class DependencyContainer
    {
        public static void AddWebApiConfigurations(this IServiceCollection services, IConfiguration config)

        {
            // Services
            services.AddScoped<IPropertyService, PropertyService>();

            // Repos

            services.AddScoped<PropertyRepository, PropertyRepository>();
            services.AddScoped<DbContext, ApplicationDbContext>();



            // Database Config
            services.AddRemedyDatabase(config);
        }

        public static IServiceCollection AddRemedyDatabase(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = config.GetConnectionString("StringSQL");
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("RealState.Service.WebAPI").MigrationsHistoryTable("__EFMigrationsHistory_Data"));
            });
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // TODO: Seed data
            // if (environment.ToLower() == "development") 
            //    services.AddScoped<DbInitializer>();

            return services;
        }
    }

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealState.Application.Interfaces.Generics;
using RealState.Application.Interfaces.Properties;
using RealState.Application.Services;
using RealState.Infrastruture.Data.Contexts;
using RealState.Infrastruture.Data.Repositories;
using RealState.Infrastruture.Interfaces.Repositories;

namespace RealState.Infrastruture.IoC
{
    public static class DependencyContainer
    {
        public static void AddConsoleAppConfiguration(this IServiceCollection services, IConfiguration config)
        {
            services.AddCommonConfigurations(config);
        }

        public static void AddWebAppConfiguration(this IServiceCollection services, IConfiguration config)
        {
            services.AddCommonConfigurations(config);
        }


        public static void AddWebApiConfiguration(this IServiceCollection services, IConfiguration config)
        {
            services.AddCommonConfigurations(config);
        }

        private static void AddCommonConfigurations(this IServiceCollection services, IConfiguration config)
        {
        //    services.AddDbContext<RealStateContext>(options =>
        //options.UseSqlServer(config.GetConnectionString("StringSQL")));

            // Add services
            services.AddScoped<IPropertyService, PropertyService>();

            // Add Repos
            services.AddScoped<IPropertyRepository, PropertyRepository>();

        }
    }
}

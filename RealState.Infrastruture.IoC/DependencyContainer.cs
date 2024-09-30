using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealState.Application.Interfaces.Propertizz.Addresses;
using RealState.Application.Interfaces.Propertizz.Prices;
using RealState.Application.Interfaces.Propertizz.Properties;
using RealState.Application.Interfaces.Propertizz.Typologies;
using RealState.Application.Interfaces.UnitOfWork;
using RealState.Application.Interfaces.Userzz.Users;
using RealState.Application.Services.Propertizz;
using RealState.Application.Services.Userzz;
using RealState.Infrastruture.Data.Repositories.Addresses;
using RealState.Infrastruture.Data.Repositories.ApplicationDbContexts;
using RealState.Infrastruture.Data.Repositories.Prices;
using RealState.Infrastruture.Data.Repositories.Properties;
using RealState.Infrastruture.Data.Repositories.Typologies;
using RealState.Infrastruture.Data.Repositories.UnitsOkWorks;
using RealState.Infrastruture.Data.Repositories.Users;


namespace RealState.Infrastruture.IoC;

public static class DependencyContainer
    {
        public static void AddWebApiConfigurations(this IServiceCollection services, IConfiguration config)

        {
            // Services
            services.AddScoped<IPropertyService, PropertyService>();
            services.AddScoped<ITypologyService, TypologyService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IPriceService, PriceService>();
            services.AddScoped<IUserService, UserService>();
            // Repos

            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<ITypologyRepository, TypologyRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IPriceRepository, PriceRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<DbContext, ApplicationDbContext>();



            // Database Config
            services.AddRealEstateDatabase(config);
        }

        public static IServiceCollection AddRealEstateDatabase(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = config.GetConnectionString("StringSQL");
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("RealState.Service.WebAPI").MigrationsHistoryTable("__EFMigrationsHistory_Data"));
            });
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");


            return services;
        }
    }

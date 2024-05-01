
using Microsoft.EntityFrameworkCore;
using RealState.Infrastruture.Data.Contexts;
using RealState.Infrastruture.IoC;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

       
     
        //builder.Services.AddWebApiConfiguration(configuration);

        builder.Services.AddControllers();
        builder.Services.AddDbContext<RealStateContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("StringSQL")));

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
 }

using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Data;
using NorthwindAPI.Data.Repositories;
using NorthwindAPI.Models;
using NorthwindAPI.Services;

namespace NorthwindAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Logging.ClearProviders();
        builder.Logging.AddConsole();

        // Add services to the container.
        var dbConnection = builder.Configuration["DefaultConnection"];

        builder.Services.AddDbContext<NorthwindContext>(
            opt => opt.UseSqlServer(dbConnection));

        builder.Services.AddControllers()
            .AddNewtonsoftJson(
            opt => opt.SerializerSettings
            .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

        builder.Services.AddScoped(typeof(INorthwindRepository<>), typeof(NorthwindRepository<>));

        builder.Services.AddScoped(typeof(INorthwindService<>), typeof(NorthwindService<>));

        builder.Services.AddScoped<INorthwindRepository<Customer>, SupplierRepository>();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
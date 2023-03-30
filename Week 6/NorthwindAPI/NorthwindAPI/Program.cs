
using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Data;

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

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        //builder.Services.AddEndpointsApiExplorer();
        //builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            //app.UseSwagger();
            //app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
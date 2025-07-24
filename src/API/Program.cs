using Api.Configurations;
using API.Endpoints;
using Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Configuração do EF Core
        builder.Services.AddDbContext<SeriesCatalogDbContext>(options =>
            options.UseSqlite("Data Source=SeriesCatalog.db"));

        // DependencyInjection
        builder.Services.AddServices();
        builder.Services.AddRepositories();

        // Swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Swagger
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // Configure endpoints
        app.SeriesEndpoints();

        app.Run();
    }
}
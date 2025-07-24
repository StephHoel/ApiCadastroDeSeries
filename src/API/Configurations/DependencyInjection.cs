using Application.Services.GetSeries;
using Domain.Interfaces.Repositories;
using Infra.Repositories;

namespace Api.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ISeriesRepository, SeriesRepository>();

        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IGetSeriesService, GetSeriesService>();

        return services;
    }
}
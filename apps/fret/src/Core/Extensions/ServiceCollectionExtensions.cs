using Fret.APIs;

namespace Fret;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<ICommonsService, CommonsService>();
        services.AddScoped<IContainersService, ContainersService>();
        services.AddScoped<ILinesService, LinesService>();
        services.AddScoped<IManifestsService, ManifestsService>();
        services.AddScoped<ITrailersService, TrailersService>();
        services.AddScoped<ITrainsService, TrainsService>();
        services.AddScoped<IVehiclesService, VehiclesService>();
    }
}

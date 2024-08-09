using Statement.APIs;

namespace Statement;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IAttachmentsService, AttachmentsService>();
        services.AddScoped<ICancellationsService, CancellationsService>();
        services.AddScoped<IContainersService, ContainersService>();
        services.AddScoped<IOperatorsService, OperatorsService>();
    }
}

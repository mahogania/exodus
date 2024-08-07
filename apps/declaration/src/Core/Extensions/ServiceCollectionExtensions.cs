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
    }
}

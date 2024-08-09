using Evaluation.APIs;

namespace Evaluation;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<ICommonsService, CommonsService>();
        services.AddScoped<IDetailsService, DetailsService>();
        services.AddScoped<IExpressesService, ExpressesService>();
        services.AddScoped<IItemsService, ItemsService>();
        services.AddScoped<IRequestsService, RequestsService>();
    }
}

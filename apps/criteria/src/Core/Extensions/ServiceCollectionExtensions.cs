using Criteria.APIs;

namespace Criteria;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IAgentVisitsService, AgentVisitsService>();
        services.AddScoped<IClearanceFretContainersService, ClearanceFretContainersService>();
        services.AddScoped<IClearanceFretInterfacesService, ClearanceFretInterfacesService>();
        services.AddScoped<IForeignClientsService, ForeignClientsService>();
        services.AddScoped<IInspectorChangesService, InspectorChangesService>();
        services.AddScoped<IInspectorQuotationModesService, InspectorQuotationModesService>();
        services.AddScoped<IInspectorQuotationStatsService, InspectorQuotationStatsService>();
        services.AddScoped<
            IInspectorRatingCriteriaDeclarationModelsService,
            InspectorRatingCriteriaDeclarationModelsService
        >();
        services.AddScoped<
            IInspectorRatingCriteriaInspectorsService,
            InspectorRatingCriteriaInspectorsService
        >();
        services.AddScoped<IInspectorRatingCriteriaService, InspectorRatingCriteriaService>();
        services.AddScoped<
            IInspectorVerifierDesignationsService,
            InspectorVerifierDesignationsService
        >();
        services.AddScoped<IRvcIssuancesService, RvcIssuancesService>();
        services.AddScoped<IServiceChangesService, ServiceChangesService>();
        services.AddScoped<IServiceQuotationCriteriaService, ServiceQuotationCriteriaService>();
    }
}

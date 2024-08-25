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
        services.AddScoped<IInspectorQuotationCriteriaService, InspectorQuotationCriteriaService>();
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
        services.AddScoped<
            IInspectorVerifierDesignationsService,
            InspectorVerifierDesignationsService
        >();
        services.AddScoped<IServiceQuotationCriteriaService, ServiceQuotationCriteriaService>();
    }
}

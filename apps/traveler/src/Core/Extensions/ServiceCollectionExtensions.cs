using Traveler.APIs;

namespace Traveler;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<
            IAccompaniedBaggageEntryAndExitsService,
            AccompaniedBaggageEntryAndExitsService
        >();
        services.AddScoped<IAppealsService, AppealsService>();
        services.AddScoped<IBaggageControlArticlesService, BaggageControlArticlesService>();
        services.AddScoped<IExitVouchersService, ExitVouchersService>();
        services.AddScoped<IGeneralBondNotesService, GeneralBondNotesService>();
        services.AddScoped<
            IGeneralTravelerInformationTpdsService,
            GeneralTravelerInformationTpdsService
        >();
        services.AddScoped<IImportDeclarationsService, ImportDeclarationsService>();
        services.AddScoped<
            IInspectorRatingModificationHistoriesService,
            InspectorRatingModificationHistoriesService
        >();
        services.AddScoped<ITpdControlsService, TpdControlsService>();
        services.AddScoped<ITpdEntryAndExitHistoriesService, TpdEntryAndExitHistoriesService>();
        services.AddScoped<ITpdVehiclesService, TpdVehiclesService>();
        services.AddScoped<
            ITravelersArticlesEntryExitsService,
            TravelersArticlesEntryExitsService
        >();
        services.AddScoped<ITravelerSearchHistoriesService, TravelerSearchHistoriesService>();
    }
}

using Code.APIs;

namespace Code;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<
            IArticlePaysBeneficiaireAntiDumpingsService,
            ArticlePaysBeneficiaireAntiDumpingsService
        >();
        services.AddScoped<
            IArticlePaysPartenaireConventionDouanieresService,
            ArticlePaysPartenaireConventionDouanieresService
        >();
        services.AddScoped<
            IArticlePeriodeApplicationTarifNormalsService,
            ArticlePeriodeApplicationTarifNormalsService
        >();
        services.AddScoped<
            IArticlePeriodeApplicationTarifSpecialsService,
            ArticlePeriodeApplicationTarifSpecialsService
        >();
        services.AddScoped<IArticleTarifsService, ArticleTarifsService>();
        services.AddScoped<IComparaisonShEntrePaysService, ComparaisonShEntrePaysService>();
        services.AddScoped<IPaysPreferentielsService, PaysPreferentielsService>();
        services.AddScoped<IPeriodeTarifNormalGeneralsService, PeriodeTarifNormalGeneralsService>();
        services.AddScoped<
            IPeriodeTarifSpecialGeneralsService,
            PeriodeTarifSpecialGeneralsService
        >();
        services.AddScoped<
            IPrixUnitaireDeclarationDetailsService,
            PrixUnitaireDeclarationDetailsService
        >();
        services.AddScoped<IShAnalyseCollectionsService, ShAnalyseCollectionsService>();
        services.AddScoped<
            IShAnalyseCollectionEntreprisesService,
            ShAnalyseCollectionEntreprisesService
        >();
        services.AddScoped<
            IShAnalyseCollectionTemporairesService,
            ShAnalyseCollectionTemporairesService
        >();
        services.AddScoped<
            IShAnalyseCollectionTemporaire2sService,
            ShAnalyseCollectionTemporaire2sService
        >();
        services.AddScoped<
            IShAnalyseCollectionTemporaire3sService,
            ShAnalyseCollectionTemporaire3sService
        >();
        services.AddScoped<
            IShAnalyseEvolutionPrixCollectionsService,
            ShAnalyseEvolutionPrixCollectionsService
        >();
        services.AddScoped<IShAnalysePrixUnitairesService, ShAnalysePrixUnitairesService>();
        services.AddScoped<IShProfilsService, ShProfilsService>();
        services.AddScoped<ITarifGeneralsService, TarifGeneralsService>();
        services.AddScoped<IValeurBoursieresService, ValeurBoursieresService>();
    }
}

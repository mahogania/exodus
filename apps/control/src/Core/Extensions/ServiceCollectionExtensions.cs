using Control.APIs;

namespace Control;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IAnalysisRequestsService, AnalysisRequestsService>();
        services.AddScoped<IAppealsService, AppealsService>();
        services.AddScoped<IArticlesService, ArticlesService>();
        services.AddScoped<IArticleAssessmentsService, ArticleAssessmentsService>();
        services.AddScoped<IArticleCarnetControlsService, ArticleCarnetControlsService>();
        services.AddScoped<IArticleCarnetRequestsService, ArticleCarnetRequestsService>();
        services.AddScoped<
            IArticlesSubmittedForVerificationsService,
            ArticlesSubmittedForVerificationsService
        >();
        services.AddScoped<ICancellationRequestsService, CancellationRequestsService>();
        services.AddScoped<ICarnetControlsService, CarnetControlsService>();
        services.AddScoped<ICommonActiveGoodsRequestsService, CommonActiveGoodsRequestsService>();
        services.AddScoped<ICommonCarnetRequestsService, CommonCarnetRequestsService>();
        services.AddScoped<ICommonDetailedDeclarationsService, CommonDetailedDeclarationsService>();
        services.AddScoped<ICommonExpressClearancesService, CommonExpressClearancesService>();
        services.AddScoped<
            ICommonOriginCertificateRequestsService,
            CommonOriginCertificateRequestsService
        >();
        services.AddScoped<ICommonRegimeRequestsService, CommonRegimeRequestsService>();
        services.AddScoped<ICommonVerificationsService, CommonVerificationsService>();
        services.AddScoped<
            IContainerOfTheDetailedDeclarationCustomsService,
            ContainerOfTheDetailedDeclarationCustomsService
        >();
        services.AddScoped<IContainerValueAssessmentsService, ContainerValueAssessmentsService>();
        services.AddScoped<IDetailedDeclarationTaxesService, DetailedDeclarationTaxesService>();
        services.AddScoped<IDetailOfActiveGoodsService, DetailOfActiveGoodsService>();
        services.AddScoped<
            IDetailOfRequestForOriginCertificatesService,
            DetailOfRequestForOriginCertificatesService
        >();
        services.AddScoped<
            IExpectedReimportReexportArticlesService,
            ExpectedReimportReexportArticlesService
        >();
        services.AddScoped<
            IExpressCustomsClearanceDetailsService,
            ExpressCustomsClearanceDetailsService
        >();
        services.AddScoped<
            IExtendedPeriodCarnetControlsService,
            ExtendedPeriodCarnetControlsService
        >();
        services.AddScoped<
            IExtendedPeriodCarnetRequestsService,
            ExtendedPeriodCarnetRequestsService
        >();
        services.AddScoped<IForeignOperatorRequestsService, ForeignOperatorRequestsService>();
        services.AddScoped<IImportCarnetControlsService, ImportCarnetControlsService>();
        services.AddScoped<IImportCarnetRequestsService, ImportCarnetRequestsService>();
        services.AddScoped<IJointDocumentsService, JointDocumentsService>();
        services.AddScoped<
            IModelofDetailedDeclarationsService,
            ModelofDetailedDeclarationsService
        >();
        services.AddScoped<
            IModelValueEvaluationVerificationsService,
            ModelValueEvaluationVerificationsService
        >();
        services.AddScoped<IOperatorsService, OperatorsService>();
        services.AddScoped<IPostalGoodsClearancesService, PostalGoodsClearancesService>();
        services.AddScoped<
            IPostalGoodsClearanceDetailsService,
            PostalGoodsClearanceDetailsService
        >();
        services.AddScoped<
            IPostalParcelSimplifiedClearancesService,
            PostalParcelSimplifiedClearancesService
        >();
        services.AddScoped<IProceduresService, ProceduresService>();
        services.AddScoped<IRawMaterialsService, RawMaterialsService>();
        services.AddScoped<IRecourseRequestsService, RecourseRequestsService>();
        services.AddScoped<IReexportCarnetControlsService, ReexportCarnetControlsService>();
        services.AddScoped<IReexportCarnetRequestsService, ReexportCarnetRequestsService>();
        services.AddScoped<ISampleRequestsService, SampleRequestsService>();
        services.AddScoped<ITaxForVerificationsService, TaxForVerificationsService>();
        services.AddScoped<ITransitCarnetControlsService, TransitCarnetControlsService>();
        services.AddScoped<ITransitCarnetRequestsService, TransitCarnetRequestsService>();
        services.AddScoped<IValueAssessmentsService, ValueAssessmentsService>();
        services.AddScoped<IValueDeclarationsService, ValueDeclarationsService>();
        services.AddScoped<IVehiclesService, VehiclesService>();
        services.AddScoped<IVerificationResultsService, VerificationResultsService>();
        services.AddScoped<IVerificationResultDetailsService, VerificationResultDetailsService>();
    }
}

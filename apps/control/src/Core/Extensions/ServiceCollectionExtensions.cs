using Control.APIs;

namespace Control;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IArticlesService, ArticlesService>();
        services.AddScoped<IArticleAssessmentsService, ArticleAssessmentsService>();
        services.AddScoped<IArticleCarnetControlsService, ArticleCarnetControlsService>();
        services.AddScoped<IArticleCarnetRequestsService, ArticleCarnetRequestsService>();
        services.AddScoped<ICancellationRequestsService, CancellationRequestsService>();
        services.AddScoped<ICommonActiveGoodsRequestsService, CommonActiveGoodsRequestsService>();
        services.AddScoped<ICommonCarnetRequestsService, CommonCarnetRequestsService>();
        services.AddScoped<ICommonDetailedDeclarationsService, CommonDetailedDeclarationsService>();
        services.AddScoped<ICommonExpressClearancesService, CommonExpressClearancesService>();
        services.AddScoped<
            ICommonOriginCertificateRequestsService,
            CommonOriginCertificateRequestsService
        >();
        services.AddScoped<ICommonRegimeRequestsService, CommonRegimeRequestsService>();
        services.AddScoped<
            IContainerOfTheDetailedDeclarationCustomsService,
            ContainerOfTheDetailedDeclarationCustomsService
        >();
        services.AddScoped<IDetailedDeclarationTaxesService, DetailedDeclarationTaxesService>();
        services.AddScoped<IDetailOfActiveGoodsService, DetailOfActiveGoodsService>();
        services.AddScoped<
            IDetailOfRequestForOriginCertificatesService,
            DetailOfRequestForOriginCertificatesService
        >();
        services.AddScoped<
            IDetailOfTheApprovalOfTheRegimeRequestsService,
            DetailOfTheApprovalOfTheRegimeRequestsService
        >();
        services.AddScoped<
            IDirectImportationExportationsService,
            DirectImportationExportationsService
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
        services.AddScoped<IImportedGoodsInformationsService, ImportedGoodsInformationsService>();
        services.AddScoped<IItinerariesService, ItinerariesService>();
        services.AddScoped<IJointDocumentsService, JointDocumentsService>();
        services.AddScoped<IJournalsService, JournalsService>();
        services.AddScoped<
            IModelofDetailedDeclarationsService,
            ModelofDetailedDeclarationsService
        >();
        services.AddScoped<IOperatorsService, OperatorsService>();
        services.AddScoped<
            IOriginDeterminingInformationsService,
            OriginDeterminingInformationsService
        >();
        services.AddScoped<IPostalGoodsClearancesService, PostalGoodsClearancesService>();
        services.AddScoped<
            IPostalGoodsClearanceDetailsService,
            PostalGoodsClearanceDetailsService
        >();
        services.AddScoped<
            IPostalParcelSimplifiedClearancesService,
            PostalParcelSimplifiedClearancesService
        >();
        services.AddScoped<IRawMaterialsService, RawMaterialsService>();
        services.AddScoped<IRCODemandsService, RCODemandsService>();
        services.AddScoped<IRecourseRequestsService, RecourseRequestsService>();
        services.AddScoped<IReexportCarnetControlsService, ReexportCarnetControlsService>();
        services.AddScoped<IReexportCarnetRequestsService, ReexportCarnetRequestsService>();
        services.AddScoped<
            ITemporaryAdmissionForPerfectionsService,
            TemporaryAdmissionForPerfectionsService
        >();
        services.AddScoped<
            ITemporaryAdmissionOfVehiclesService,
            TemporaryAdmissionOfVehiclesService
        >();
        services.AddScoped<ITransitCarnetControlsService, TransitCarnetControlsService>();
        services.AddScoped<ITransitCarnetRequestsService, TransitCarnetRequestsService>();
        services.AddScoped<IValueAssessmentsService, ValueAssessmentsService>();
        services.AddScoped<IValueDeclarationsService, ValueDeclarationsService>();
        services.AddScoped<IVehiclesService, VehiclesService>();
        services.AddScoped<IWarehouseTransfersService, WarehouseTransfersService>();
    }
}

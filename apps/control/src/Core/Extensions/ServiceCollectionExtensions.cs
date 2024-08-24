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
        services.AddScoped<IAtAndStandardExchangesService, AtAndStandardExchangesService>();
        services.AddScoped<
            IAtWithReExportationInTheStatesService,
            AtWithReExportationInTheStatesService
        >();
        services.AddScoped<ICancellationRequestsService, CancellationRequestsService>();
        services.AddScoped<ICarnetRequestsService, CarnetRequestsService>();
        services.AddScoped<
            IChangeInTheDetailedDeclarationsService,
            ChangeInTheDetailedDeclarationsService
        >();
        services.AddScoped<ICommonActiveGoodsRequestsService, CommonActiveGoodsRequestsService>();
        services.AddScoped<ICommonAtaCarnetControlsService, CommonAtaCarnetControlsService>();
        services.AddScoped<ICommonAtaCarnetControlAltsService, CommonAtaCarnetControlAltsService>();
        services.AddScoped<ICommonDetailedDeclarationsService, CommonDetailedDeclarationsService>();
        services.AddScoped<ICommonExpressClearancesService, CommonExpressClearancesService>();
        services.AddScoped<
            ICommonOriginCertificateRequestsService,
            CommonOriginCertificateRequestsService
        >();
        services.AddScoped<ICommonRegimeRequestsService, CommonRegimeRequestsService>();
        services.AddScoped<
            ICompensatoryProductsForPerfectionsService,
            CompensatoryProductsForPerfectionsService
        >();
        services.AddScoped<
            IContainerOfTheDetailedDeclarationCustomsService,
            ContainerOfTheDetailedDeclarationCustomsService
        >();
        services.AddScoped<ICustomsDeclarationBondsService, CustomsDeclarationBondsService>();
        services.AddScoped<
            IDefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesService,
            DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesService
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
            IDetailsOfGoodsForPassivePerfectionsService,
            DetailsOfGoodsForPassivePerfectionsService
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
            IExportedAndForImprovementGoodsService,
            ExportedAndForImprovementGoodsService
        >();
        services.AddScoped<
            IExportedOrToBeExportedGoodsInformationsService,
            ExportedOrToBeExportedGoodsInformationsService
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
        services.AddScoped<
            IFinalExportFollowedByReimportationInTheStatesService,
            FinalExportFollowedByReimportationInTheStatesService
        >();
        services.AddScoped<IForeignOperatorRequestsService, ForeignOperatorRequestsService>();
        services.AddScoped<
            IGoodsAndWithReImportationInStatesService,
            GoodsAndWithReImportationInStatesService
        >();
        services.AddScoped<
            IGoodsImportedForPerfectingsService,
            GoodsImportedForPerfectingsService
        >();
        services.AddScoped<
            IGoodsMacSuiteAtAndWithReExportationInStatesService,
            GoodsMacSuiteAtAndWithReExportationInStatesService
        >();
        services.AddScoped<
            IGoodsSubjectToAuthorizationsService,
            GoodsSubjectToAuthorizationsService
        >();
        services.AddScoped<IImportCarnetControlsService, ImportCarnetControlsService>();
        services.AddScoped<IImportCarnetRequestsService, ImportCarnetRequestsService>();
        services.AddScoped<IImportedGoodsInformationsService, ImportedGoodsInformationsService>();
        services.AddScoped<IImportedMaterialWastesService, ImportedMaterialWastesService>();
        services.AddScoped<
            IImportExportDetailedStatementsService,
            ImportExportDetailedStatementsService
        >();
        services.AddScoped<
            IInformationOfGoodsAtAndStandardExchangesService,
            InformationOfGoodsAtAndStandardExchangesService
        >();
        services.AddScoped<
            IInformationOfGoodsTransferredInWarehousePublicPrivatesService,
            InformationOfGoodsTransferredInWarehousePublicPrivatesService
        >();
        services.AddScoped<
            IInfosGoodsToBeReprovisionedsService,
            InfosGoodsToBeReprovisionedsService
        >();
        services.AddScoped<IItinerariesService, ItinerariesService>();
        services.AddScoped<IJointDocumentsService, JointDocumentsService>();
        services.AddScoped<IJournalsService, JournalsService>();
        services.AddScoped<IMacSubjectToAuthorizationsService, MacSubjectToAuthorizationsService>();
        services.AddScoped<
            IMacSuiteAtWithReexportationInTheStatesService,
            MacSuiteAtWithReexportationInTheStatesService
        >();
        services.AddScoped<
            IMaterialsAtWithReexportationInTheStatesService,
            MaterialsAtWithReexportationInTheStatesService
        >();
        services.AddScoped<
            IModelofDetailedDeclarationsService,
            ModelofDetailedDeclarationsService
        >();
        services.AddScoped<IOperatorsService, OperatorsService>();
        services.AddScoped<
            IOriginDeterminingInformationsService,
            OriginDeterminingInformationsService
        >();
        services.AddScoped<
            IPlaceOfExecutionAndWithReImportationInStatesService,
            PlaceOfExecutionAndWithReImportationInStatesService
        >();
        services.AddScoped<
            IPlaceOfExecutionAtWithReexportationInTheStatesService,
            PlaceOfExecutionAtWithReexportationInTheStatesService
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
        services.AddScoped<
            IRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsService,
            RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsService
        >();
        services.AddScoped<IRawMaterialsService, RawMaterialsService>();
        services.AddScoped<IRCODemandsService, RCODemandsService>();
        services.AddScoped<IReexportCarnetControlsService, ReexportCarnetControlsService>();
        services.AddScoped<IReexportCarnetRequestsService, ReexportCarnetRequestsService>();
        services.AddScoped<
            IReimportedGoodsForPerfectingsService,
            ReimportedGoodsForPerfectingsService
        >();
        services.AddScoped<IReplenishmentsService, ReplenishmentsService>();
        services.AddScoped<IRequestForCommonCarnetsService, RequestForCommonCarnetsService>();
        services.AddScoped<IRequestForRecoursesService, RequestForRecoursesService>();
        services.AddScoped<
            IRequestForTirCarnetOfTheArticlesService,
            RequestForTirCarnetOfTheArticlesService
        >();
        services.AddScoped<IStateForPerfectionsService, StateForPerfectionsService>();
        services.AddScoped<
            IStateOfGoodsForPassivePerfectionCommonsService,
            StateOfGoodsForPassivePerfectionCommonsService
        >();
        services.AddScoped<
            IStateWithReImportationInTheStatesService,
            StateWithReImportationInTheStatesService
        >();
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

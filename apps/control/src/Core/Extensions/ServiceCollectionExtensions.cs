using Control.APIs;

namespace Control;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<
            IArticleOfTheDetailedDeclarationCustomsService,
            ArticleOfTheDetailedDeclarationCustomsService
        >();
        services.AddScoped<IAtAndStandardExchangesService, AtAndStandardExchangesService>();
        services.AddScoped<
            IAtWithReExportationInTheStatesService,
            AtWithReExportationInTheStatesService
        >();
        services.AddScoped<
            ICommonActivePerfectioningGoodsRequestsService,
            CommonActivePerfectioningGoodsRequestsService
        >();
        services.AddScoped<ICommonDetailedDeclarationsService, CommonDetailedDeclarationsService>();
        services.AddScoped<
            ICommonDetailedDeclarationCustomsValueAssessmentsService,
            CommonDetailedDeclarationCustomsValueAssessmentsService
        >();
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
        services.AddScoped<
            ICustomsClearanceOfPostalGoodsService,
            CustomsClearanceOfPostalGoodsService
        >();
        services.AddScoped<ICustomsDeclarationBondsService, CustomsDeclarationBondsService>();
        services.AddScoped<
            ICustomsDetailedDeclarationTaxesService,
            CustomsDetailedDeclarationTaxesService
        >();
        services.AddScoped<
            ICustomsDetailedDeclarationValueAssessmentArticlesService,
            CustomsDetailedDeclarationValueAssessmentArticlesService
        >();
        services.AddScoped<
            IDeclarationOfValueOfTheDetailedDeclarationCustomsService,
            DeclarationOfValueOfTheDetailedDeclarationCustomsService
        >();
        services.AddScoped<
            IDefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesService,
            DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesService
        >();
        services.AddScoped<IDemandForRcoClresService, DemandForRcoClresService>();
        services.AddScoped<
            IDetailedDeclarationOperatorCustomsService,
            DetailedDeclarationOperatorCustomsService
        >();
        services.AddScoped<
            IDetailedDeclarationVehiclesService,
            DetailedDeclarationVehiclesService
        >();
        services.AddScoped<
            IDetailOfRequestForCertificateOfOriginsService,
            DetailOfRequestForCertificateOfOriginsService
        >();
        services.AddScoped<
            IDetailsOfAtGoodsForActivePerfectingsService,
            DetailsOfAtGoodsForActivePerfectingsService
        >();
        services.AddScoped<
            IDetailsOfGoodsForPassivePerfectionsService,
            DetailsOfGoodsForPassivePerfectionsService
        >();
        services.AddScoped<
            IDetailsOfTheApprovalOfTheRegimeRequestsService,
            DetailsOfTheApprovalOfTheRegimeRequestsService
        >();
        services.AddScoped<
            IDetailsOfTheCustomsClearanceOfPostalGoodsService,
            DetailsOfTheCustomsClearanceOfPostalGoodsService
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
        services.AddScoped<IImportedGoodsInformationsService, ImportedGoodsInformationsService>();
        services.AddScoped<IImportedMaterialWastesService, ImportedMaterialWastesService>();
        services.AddScoped<
            IImportExportDetailedStatementsService,
            ImportExportDetailedStatementsService
        >();
        services.AddScoped<
            IInformationForDeterminingOriginsService,
            InformationForDeterminingOriginsService
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
        services.AddScoped<
            IJointDocumentOfTheDetailedDeclarationCustomsService,
            JointDocumentOfTheDetailedDeclarationCustomsService
        >();
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
            IModelSpecificationOfTheDetailedDeclarationCustomsService,
            ModelSpecificationOfTheDetailedDeclarationCustomsService
        >();
        services.AddScoped<
            IPlaceOfExecutionAndWithReImportationInStatesService,
            PlaceOfExecutionAndWithReImportationInStatesService
        >();
        services.AddScoped<
            IPlaceOfExecutionAtWithReexportationInTheStatesService,
            PlaceOfExecutionAtWithReexportationInTheStatesService
        >();
        services.AddScoped<
            IRatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsService,
            RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsService
        >();
        services.AddScoped<
            IRawMaterialOfTheDetailedDeclarationCustomsService,
            RawMaterialOfTheDetailedDeclarationCustomsService
        >();
        services.AddScoped<
            IReimportedGoodsForPerfectingsService,
            ReimportedGoodsForPerfectingsService
        >();
        services.AddScoped<IReplenishmentInDutyFreesService, ReplenishmentInDutyFreesService>();
        services.AddScoped<
            IRequestForCancellationOfTheDetailedDeclarationCustomsService,
            RequestForCancellationOfTheDetailedDeclarationCustomsService
        >();
        services.AddScoped<IRequestForCommonCarnetsService, RequestForCommonCarnetsService>();
        services.AddScoped<IRequestForRecoursesService, RequestForRecoursesService>();
        services.AddScoped<
            IRequestForTirCarnetOfTheArticlesService,
            RequestForTirCarnetOfTheArticlesService
        >();
        services.AddScoped<
            ISimplifiedCustomsClearanceOfPostalParcelsService,
            SimplifiedCustomsClearanceOfPostalParcelsService
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
        services.AddScoped<
            ITextZoneForSpecifyingTheItinerariesService,
            TextZoneForSpecifyingTheItinerariesService
        >();
        services.AddScoped<
            IWarehouseTransferPublicPrivatesService,
            WarehouseTransferPublicPrivatesService
        >();
    }
}

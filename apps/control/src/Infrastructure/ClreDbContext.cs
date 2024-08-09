using Clre.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Clre.Infrastructure;

public class ClreDbContext : IdentityDbContext<IdentityUser>
{
    public ClreDbContext(DbContextOptions<ClreDbContext> options)
        : base(options) { }

    public DbSet<DirectImportationExportationDbModel> DirectImportationExportations { get; set; }

    public DbSet<CommonExpressClearanceDbModel> CommonExpressClearances { get; set; }

    public DbSet<CompensatoryProductsForPerfectionDbModel> CompensatoryProductsForPerfections { get; set; }

    public DbSet<InformationForDeterminingOriginDbModel> InformationForDeterminingOrigins { get; set; }

    public DbSet<TemporaryAdmissionOfVehicleDbModel> TemporaryAdmissionOfVehicles { get; set; }

    public DbSet<StateOfGoodsForPassivePerfectionCommonDbModel> StateOfGoodsForPassivePerfectionCommons { get; set; }

    public DbSet<CustomsClearanceOfPostalGoodsDbModel> CustomsClearanceOfPostalGoodsItems { get; set; }

    public DbSet<TemporaryAdmissionForPerfectionDbModel> TemporaryAdmissionForPerfections { get; set; }

    public DbSet<ArticleOfTheDetailedDeclarationCustomsDbModel> ArticleOfTheDetailedDeclarationCustomsItems { get; set; }

    public DbSet<ForeignOperatorRequestDbModel> ForeignOperatorRequests { get; set; }

    public DbSet<CommonRegimeRequestDbModel> CommonRegimeRequests { get; set; }

    public DbSet<DetailedDeclarationOperatorCustomsDbModel> DetailedDeclarationOperatorCustomsItems { get; set; }

    public DbSet<DetailsOfAtGoodsForActivePerfectingDbModel> DetailsOfAtGoodsForActivePerfectings { get; set; }

    public DbSet<GoodsImportedForPerfectingDbModel> GoodsImportedForPerfectings { get; set; }

    public DbSet<RequestForCommonCarnetDbModel> RequestForCommonCarnets { get; set; }

    public DbSet<ReimportedGoodsForPerfectingDbModel> ReimportedGoodsForPerfectings { get; set; }

    public DbSet<GoodsSubjectToAuthorizationDbModel> GoodsSubjectToAuthorizations { get; set; }

    public DbSet<SimplifiedCustomsClearanceOfPostalParcelsDbModel> SimplifiedCustomsClearanceOfPostalParcelsItems { get; set; }

    public DbSet<DeclarationOfValueOfTheDetailedDeclarationCustomsDbModel> DeclarationOfValueOfTheDetailedDeclarationCustomsItems { get; set; }

    public DbSet<DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateDbModel> DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates { get; set; }

    public DbSet<PlaceOfExecutionAtWithReexportationInTheStateDbModel> PlaceOfExecutionAtWithReexportationInTheStates { get; set; }

    public DbSet<CustomsDeclarationBondDbModel> CustomsDeclarationBonds { get; set; }

    public DbSet<ExpectedReimportReexportArticleDbModel> ExpectedReimportReexportArticles { get; set; }

    public DbSet<CommonDetailedDeclarationDbModel> CommonDetailedDeclarations { get; set; }

    public DbSet<ExpressCustomsClearanceDetailsDbModel> ExpressCustomsClearanceDetailsItems { get; set; }

    public DbSet<CustomsDetailedDeclarationTaxDbModel> CustomsDetailedDeclarationTaxes { get; set; }

    public DbSet<MacSuiteAtWithReexportationInTheStateDbModel> MacSuiteAtWithReexportationInTheStates { get; set; }

    public DbSet<InfosGoodsToBeReprovisionedDbModel> InfosGoodsToBeReprovisioneds { get; set; }

    public DbSet<AtAndStandardExchangeDbModel> AtAndStandardExchanges { get; set; }

    public DbSet<InformationOfGoodsAtAndStandardExchangeDbModel> InformationOfGoodsAtAndStandardExchanges { get; set; }

    public DbSet<InformationOfGoodsTransferredInWarehousePublicPrivateDbModel> InformationOfGoodsTransferredInWarehousePublicPrivates { get; set; }

    public DbSet<ContainerOfTheDetailedDeclarationCustomsDbModel> ContainerOfTheDetailedDeclarationCustomsItems { get; set; }

    public DbSet<ImportedGoodsInformationDbModel> ImportedGoodsInformations { get; set; }

    public DbSet<RequestForCancellationOfTheDetailedDeclarationCustomsDbModel> RequestForCancellationOfTheDetailedDeclarationCustomsItems { get; set; }

    public DbSet<DemandForRcoClreDbModel> DemandForRcoClres { get; set; }

    public DbSet<WarehouseTransferPublicPrivateDbModel> WarehouseTransferPublicPrivates { get; set; }

    public DbSet<DetailOfRequestForCertificateOfOriginDbModel> DetailOfRequestForCertificateOfOrigins { get; set; }

    public DbSet<RawMaterialOfTheDetailedDeclarationCustomsDbModel> RawMaterialOfTheDetailedDeclarationCustomsItems { get; set; }

    public DbSet<ImportedMaterialWasteDbModel> ImportedMaterialWastes { get; set; }

    public DbSet<StateWithReImportationInTheStateDbModel> StateWithReImportationInTheStates { get; set; }

    public DbSet<TextZoneForSpecifyingTheItineraryDbModel> TextZoneForSpecifyingTheItineraries { get; set; }

    public DbSet<DetailsOfGoodsForPassivePerfectionDbModel> DetailsOfGoodsForPassivePerfections { get; set; }

    public DbSet<StateForPerfectionDbModel> StateForPerfections { get; set; }

    public DbSet<MacSubjectToAuthorizationDbModel> MacSubjectToAuthorizations { get; set; }

    public DbSet<ModelSpecificationOfTheDetailedDeclarationCustomsDbModel> ModelSpecificationOfTheDetailedDeclarationCustomsItems { get; set; }

    public DbSet<CommonActivePerfectioningGoodsRequestDbModel> CommonActivePerfectioningGoodsRequests { get; set; }

    public DbSet<JointDocumentOfTheDetailedDeclarationCustomsDbModel> JointDocumentOfTheDetailedDeclarationCustomsItems { get; set; }

    public DbSet<AtWithReExportationInTheStateDbModel> AtWithReExportationInTheStates { get; set; }

    public DbSet<CommonDetailedDeclarationCustomsValueAssessmentDbModel> CommonDetailedDeclarationCustomsValueAssessments { get; set; }

    public DbSet<RequestForRecourseDbModel> RequestForRecourses { get; set; }

    public DbSet<GoodsAndWithReImportationInStateDbModel> GoodsAndWithReImportationInStates { get; set; }

    public DbSet<PlaceOfExecutionAndWithReImportationInStateDbModel> PlaceOfExecutionAndWithReImportationInStates { get; set; }

    public DbSet<GoodsMacSuiteAtAndWithReExportationInStateDbModel> GoodsMacSuiteAtAndWithReExportationInStates { get; set; }

    public DbSet<ImportExportDetailedStatementDbModel> ImportExportDetailedStatements { get; set; }

    public DbSet<RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsDbModel> RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsItems { get; set; }

    public DbSet<DetailedDeclarationVehicleDbModel> DetailedDeclarationVehicles { get; set; }

    public DbSet<ReplenishmentInDutyFreeDbModel> ReplenishmentInDutyFrees { get; set; }

    public DbSet<CustomsDetailedDeclarationValueAssessmentArticleDbModel> CustomsDetailedDeclarationValueAssessmentArticles { get; set; }

    public DbSet<DetailsOfTheApprovalOfTheRegimeRequestDbModel> DetailsOfTheApprovalOfTheRegimeRequests { get; set; }

    public DbSet<ExportedOrToBeExportedGoodsInformationDbModel> ExportedOrToBeExportedGoodsInformations { get; set; }

    public DbSet<DetailsOfTheCustomsClearanceOfPostalGoodsDbModel> DetailsOfTheCustomsClearanceOfPostalGoodsItems { get; set; }

    public DbSet<RequestForTirCarnetOfTheArticleDbModel> RequestForTirCarnetOfTheArticles { get; set; }

    public DbSet<MaterialsAtWithReexportationInTheStateDbModel> MaterialsAtWithReexportationInTheStates { get; set; }

    public DbSet<ExportedAndForImprovementGoodsDbModel> ExportedAndForImprovementGoodsItems { get; set; }

    public DbSet<FinalExportFollowedByReimportationInTheStateDbModel> FinalExportFollowedByReimportationInTheStates { get; set; }

    public DbSet<CommonOriginCertificateRequestDbModel> CommonOriginCertificateRequests { get; set; }
}

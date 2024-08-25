using Control.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Control.Infrastructure;

public class ControlDbContext : IdentityDbContext<IdentityUser>
{
    public ControlDbContext(DbContextOptions<ControlDbContext> options)
        : base(options) { }

    public DbSet<DirectImportationExportationDbModel> DirectImportationExportations { get; set; }

    public DbSet<CommonExpressClearanceDbModel> CommonExpressClearances { get; set; }

    public DbSet<OriginDeterminingInformationDbModel> OriginDeterminingInformations { get; set; }

    public DbSet<TemporaryAdmissionOfVehicleDbModel> TemporaryAdmissionOfVehicles { get; set; }

    public DbSet<PostalGoodsClearanceDbModel> PostalGoodsClearances { get; set; }

    public DbSet<ArticleDbModel> Articles { get; set; }

    public DbSet<TemporaryAdmissionForPerfectionDbModel> TemporaryAdmissionForPerfections { get; set; }

    public DbSet<ForeignOperatorRequestDbModel> ForeignOperatorRequests { get; set; }

    public DbSet<CommonRegimeRequestDbModel> CommonRegimeRequests { get; set; }

    public DbSet<DetailOfActiveGoodsDbModel> DetailOfActiveGoodsItems { get; set; }

    public DbSet<OperatorDbModel> Operators { get; set; }

    public DbSet<CommonCarnetRequestDbModel> CommonCarnetRequests { get; set; }

    public DbSet<ValueDeclarationDbModel> ValueDeclarations { get; set; }

    public DbSet<PostalParcelSimplifiedClearanceDbModel> PostalParcelSimplifiedClearances { get; set; }

    public DbSet<CommonDetailedDeclarationDbModel> CommonDetailedDeclarations { get; set; }

    public DbSet<ExpectedReimportReexportArticleDbModel> ExpectedReimportReexportArticles { get; set; }

    public DbSet<DetailedDeclarationTaxDbModel> DetailedDeclarationTaxes { get; set; }

    public DbSet<ExpressCustomsClearanceDetailsDbModel> ExpressCustomsClearanceDetailsItems { get; set; }

    public DbSet<ContainerOfTheDetailedDeclarationCustomsDbModel> ContainerOfTheDetailedDeclarationCustomsItems { get; set; }

    public DbSet<ImportedGoodsInformationDbModel> ImportedGoodsInformations { get; set; }

    public DbSet<CancellationRequestDbModel> CancellationRequests { get; set; }

    public DbSet<WarehouseTransferDbModel> WarehouseTransfers { get; set; }

    public DbSet<RCODemandDbModel> RcoDemands { get; set; }

    public DbSet<DetailOfRequestForOriginCertificateDbModel> DetailOfRequestForOriginCertificates { get; set; }

    public DbSet<RawMaterialDbModel> RawMaterials { get; set; }

    public DbSet<ItineraryDbModel> Itineraries { get; set; }

    public DbSet<ModelofDetailedDeclarationDbModel> ModelofDetailedDeclarations { get; set; }

    public DbSet<CommonActiveGoodsRequestDbModel> CommonActiveGoodsRequests { get; set; }

    public DbSet<ValueAssessmentDbModel> ValueAssessments { get; set; }

    public DbSet<JointDocumentDbModel> JointDocuments { get; set; }

    public DbSet<RecourseRequestDbModel> RecourseRequests { get; set; }

    public DbSet<VehicleDbModel> Vehicles { get; set; }

    public DbSet<ArticleAssessmentDbModel> ArticleAssessments { get; set; }

    public DbSet<DetailOfTheApprovalOfTheRegimeRequestDbModel> DetailOfTheApprovalOfTheRegimeRequests { get; set; }

    public DbSet<PostalGoodsClearanceDetailDbModel> PostalGoodsClearanceDetails { get; set; }

    public DbSet<CommonOriginCertificateRequestDbModel> CommonOriginCertificateRequests { get; set; }

    public DbSet<JournalDbModel> Journals { get; set; }

    public DbSet<ExtendedPeriodCarnetRequestDbModel> ExtendedPeriodCarnetRequests { get; set; }

    public DbSet<ExtendedPeriodCarnetControlDbModel> ExtendedPeriodCarnetControls { get; set; }

    public DbSet<TransitCarnetRequestDbModel> TransitCarnetRequests { get; set; }

    public DbSet<TransitCarnetControlDbModel> TransitCarnetControls { get; set; }

    public DbSet<ArticleCarnetRequestDbModel> ArticleCarnetRequests { get; set; }

    public DbSet<ImportCarnetRequestDbModel> ImportCarnetRequests { get; set; }

    public DbSet<ReexportCarnetRequestDbModel> ReexportCarnetRequests { get; set; }

    public DbSet<ImportCarnetControlDbModel> ImportCarnetControls { get; set; }

    public DbSet<ReexportCarnetControlDbModel> ReexportCarnetControls { get; set; }

    public DbSet<ArticleCarnetControlDbModel> ArticleCarnetControls { get; set; }

    public DbSet<CarnetControlDbModel> CarnetControls { get; set; }

    public DbSet<AppealDbModel> Appeals { get; set; }

    public DbSet<CommonVerificationDbModel> CommonVerifications { get; set; }

    public DbSet<ArticlesSubmittedForVerificationDbModel> ArticlesSubmittedForVerifications { get; set; }

    public DbSet<TaxForVerificationDbModel> TaxForVerifications { get; set; }

    public DbSet<VerificationResultDbModel> VerificationResults { get; set; }

    public DbSet<VerificationResultDetailDbModel> VerificationResultDetails { get; set; }

    public DbSet<ContainerValueAssessmentDbModel> ContainerValueAssessments { get; set; }

    public DbSet<ModelValueEvaluationVerificationDbModel> ModelValueEvaluationVerifications { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("Articles")]
public class ArticleDbModel
{
    [StringLength(1000)]
    public string? ApcCode { get; set; }

    public List<ArticleAssessmentDbModel>? ArticleAssessments { get; set; } =
        new List<ArticleAssessmentDbModel>();

    [StringLength(1000)]
    public string? ArticleName { get; set; }

    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    [StringLength(1000)]
    public string? ArticlePackageUnitCode { get; set; }

    [StringLength(1000)]
    public string? BrandName { get; set; }

    public string? CommonDetailedDeclarationId { get; set; }

    [ForeignKey(nameof(CommonDetailedDeclarationId))]
    public CommonDetailedDeclarationDbModel? CommonDetailedDeclaration { get; set; } = null;

    [StringLength(1000)]
    public string? CountryOfOriginCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? EndDateOfApcApproval { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderSId { get; set; }

    [Range(-999999999, 999999999)]
    public double? GrossWeightOfTheArticle { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Key { get; set; }

    [Range(-999999999, 999999999)]
    public double? ManagementAndMonitoringClearanceExpiryPeriod { get; set; }

    [StringLength(1000)]
    public string? ManagementOfShCodeExtractCodes { get; set; }

    public List<ModelofDetailedDeclarationDbModel>? Model { get; set; } =
        new List<ModelofDetailedDeclarationDbModel>();

    [Range(-999999999, 999999999)]
    public double? NetWeightOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? NewAndUsedProductCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfArticlePackages { get; set; }

    [StringLength(1000)]
    public string? OilTankNumber { get; set; }

    [StringLength(1000)]
    public string? ParcelDescription { get; set; }

    [StringLength(1000)]
    public string? ParcelShippingMarkNumber { get; set; }

    [StringLength(1000)]
    public string? PartialClearanceTypeCode { get; set; }

    [StringLength(1000)]
    public string? PreferentialCode { get; set; }

    [StringLength(1000)]
    public string? PreviousArticleNumber { get; set; }

    [StringLength(1000)]
    public string? PreviousDetailedDeclarationDate { get; set; }

    [StringLength(1000)]
    public string? PreviousDetailedDeclarationNumber { get; set; }

    [StringLength(1000)]
    public string? ProhibitedProductCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? Quantity { get; set; }

    [StringLength(1000)]
    public string? QuantityUnitCode { get; set; }

    [StringLength(1000)]
    public string? QuotaAuthorizationNumber { get; set; }

    public List<RawMaterialDbModel>? RawMaterials { get; set; } = new List<RawMaterialDbModel>();

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? RequestRegimeNumber { get; set; }

    [StringLength(1000)]
    public string? RtcDecisionAuthorizationNumber { get; set; }

    [StringLength(1000)]
    public string? ShCode { get; set; }

    [StringLength(1000)]
    public string? SpecificCodeForClassificationOfGoods { get; set; }

    [StringLength(1000)]
    public string? StartDateOfApcApproval { get; set; }

    [StringLength(1000)]
    public string? StatisticalValue { get; set; }

    [StringLength(1000)]
    public string? SuperiorArticleNumber { get; set; }

    public string? TaxId { get; set; }

    [ForeignKey(nameof(TaxId))]
    public DetailedDeclarationTaxDbModel? Tax { get; set; } = null;

    [Range(-999999999, 999999999)]
    public double? TaxationQuantity { get; set; }

    [StringLength(1000)]
    public string? TaxationUnit { get; set; }

    [StringLength(1000)]
    public string? TransactionArticleName { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? ValueAssessmentMethodCode { get; set; }

    public string? VehicleId { get; set; }

    [ForeignKey(nameof(VehicleId))]
    public VehicleDbModel? Vehicle { get; set; } = null;

    [StringLength(1000)]
    public string? VehicleOn { get; set; }

    [StringLength(1000)]
    public string? WarrantyExemptionAuthorizationNumber { get; set; }
}

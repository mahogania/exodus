using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ValueAssessments")]
public class ValueAssessmentDbModel
{
    public List<ArticleAssessmentDbModel>? Articles { get; set; } =
        new List<ArticleAssessmentDbModel>();

    public CommonDetailedDeclarationDbModel? CommonDetailedDeclarations { get; set; } = null;

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductedAmount { get; set; }

    [StringLength(1000)]
    public string? DeductionCurrencyCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductionExchangeRate { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductionNcyAmount { get; set; }

    public DateTime? FinalModificationDateTime { get; set; }

    [Range(-999999999, 999999999)]
    public int? FinalModifierId { get; set; }

    [Range(-999999999, 999999999)]
    public int? FirstRecorderId { get; set; }

    public DateTime? FirstRecordingDateTime { get; set; }

    [Range(-999999999, 999999999)]
    public double? FreightAmount { get; set; }

    [StringLength(1000)]
    public string? FreightCurrencyCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? FreightExchangeRate { get; set; }

    [Range(-999999999, 999999999)]
    public double? FreightNcyAmount { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? InsuranceAmount { get; set; }

    [StringLength(1000)]
    public string? InsuranceCurrencyCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? InsuranceExchangeRate { get; set; }

    [Range(-999999999, 999999999)]
    public double? InsuranceNcyAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceExchangeRate { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceNcyAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceUsdAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? OtherCostsAmount { get; set; }

    [StringLength(1000)]
    public string? OtherCostsCurrencyCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? OtherCostsExchangeRate { get; set; }

    [Range(-999999999, 999999999)]
    public double? OtherCostsNcyAmount { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalTaxableBaseNcyTotal { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalTaxableBaseUsdTotal { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalValueAssessmentNcyAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalValueAssessmentUsdAmount { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

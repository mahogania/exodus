using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("CustomsDetailedDeclarationTaxes")]
public class CustomsDetailedDeclarationTaxDbModel
{
    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? BasicTaxAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? BasicTaxableBaseAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? BasicTaxationRate { get; set; }

    [Range(-999999999, 999999999)]
    public double? CautionAmountAfterExemptionOfGuarantee { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExemptAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExemptTaxationRate { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExemptionBaseAmount { get; set; }

    [StringLength(1000)]
    public string? ExemptionTypeCode { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdDuPremierEnregistrant { get; set; }

    [Range(-999999999, 999999999)]
    public double? PaidTaxAmount { get; set; }

    [StringLength(1000)]
    public string? PaymentTypeCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TariffCategoryCode { get; set; }

    [StringLength(1000)]
    public string? TaxAdvantageCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? TaxAmount { get; set; }

    [StringLength(1000)]
    public string? TaxCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? TaxableBaseAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? TaxationRate { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

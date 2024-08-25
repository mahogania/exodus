using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("TaxForVerifications")]
public class TaxForVerificationDbModel
{
    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    public string? ArticlesSubmittedForVerificationsId { get; set; }

    [ForeignKey(nameof(ArticlesSubmittedForVerificationsId))]
    public ArticlesSubmittedForVerificationDbModel? ArticlesSubmittedForVerifications { get; set; } =
        null;

    [Range(-999999999, 999999999)]
    public double? BasicTaxAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? BasicTaxRate { get; set; }

    [Range(-999999999, 999999999)]
    public double? BasicTaxableAmount { get; set; }

    public List<CommonVerificationDbModel>? CommonVerifications { get; set; } =
        new List<CommonVerificationDbModel>();

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public DateTime? DeletedOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExemptedAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExemptedTaxRate { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExemptionBaseAmount { get; set; }

    [StringLength(1000)]
    public string? ExemptionTypeCode { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InitialRecorderId { get; set; }

    [StringLength(1000)]
    public string? NumberOfTimesOfValueEvaluation { get; set; }

    [Range(-999999999, 999999999)]
    public double? PaidTaxAmount { get; set; }

    [StringLength(1000)]
    public string? PaymentTypeCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? SecurityDepositAfterExemption { get; set; }

    [StringLength(1000)]
    public string? TariffCategoryCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? TaxAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? TaxBaseAmount { get; set; }

    [StringLength(1000)]
    public string? TaxBenefitCode { get; set; }

    [StringLength(1000)]
    public string? TaxCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? TaxRate { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

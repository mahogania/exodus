using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ModelValueEvaluationVerifications")]
public class ModelValueEvaluationVerificationDbModel
{
    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    public string? ArticlesSubmittedForVerificationId { get; set; }

    [ForeignKey(nameof(ArticlesSubmittedForVerificationId))]
    public ArticlesSubmittedForVerificationDbModel? ArticlesSubmittedForVerification { get; set; } =
        null;

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredInvoicePrice { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredQuantity { get; set; }

    [StringLength(1000)]
    public string? DeclaredQuantityUnitCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredUnitPrice { get; set; }

    public DateTime? DeletedOn { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InitialRecorderId { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedInvoicePrice { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedQuantity { get; set; }

    [StringLength(1000)]
    public string? LiquidatedQuantityUnitCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedUnitPrice { get; set; }

    [StringLength(1000)]
    public string? ModelAndSpecificationNumber { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? ValueEvaluationContent { get; set; }
}

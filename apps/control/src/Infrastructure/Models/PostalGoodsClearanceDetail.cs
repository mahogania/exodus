using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("PostalGoodsClearanceDetails")]
public class PostalGoodsClearanceDetailDbModel
{
    [Range(-999999999, 999999999)]
    public double? AmountNcyOfTheInvoiceOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountOfTheInvoiceOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? ArticleName { get; set; }

    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    [StringLength(1000)]
    public string? CountryCodeOfOrigin { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CurrencyCodeOfTheInvoiceOfTheArticle { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredInsuranceAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExchangeRateOfTheInvoiceOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? LiquidatedShCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? NetWeightOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? Quantity { get; set; }

    [StringLength(1000)]
    public string? RequestNumberOfTheCustomsClearanceOfPostalParcels { get; set; }

    [StringLength(1000)]
    public string? RevisedDescriptionOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? SequenceNumber { get; set; }

    [StringLength(1000)]
    public string? ShCode { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalWeightKg { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("CustomsDetailedDeclarationValueAssessmentArticles")]
public class CustomsDetailedDeclarationValueAssessmentArticleDbModel
{
    [Range(-999999999, 999999999)]
    public double? AmountDeductedOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountNcyDeductedOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountNcyOfTheEvaluationOfValueOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountNcyOfTheFairValueOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountNcyOfTheFreightOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountNcyOfTheInsuranceOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountNcyOfTheInvoiceOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountNcyOfTheOtherCostsOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountNycOfTheTaxableBaseOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountOfTheFreightOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountOfTheInsuranceOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountOfTheInvoiceOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountOfTheOtherCostsOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountUsdOfTheEvaluationOfValueOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountUsdOfTheFairValueOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountUsdOfTheInvoiceOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountUsdOfTheTaxableBaseOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? BasicValueOfTheFairValueOfTheArticle { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CurrencyCodeDeductedOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? CurrencyCodeOfTheFairValueOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? CurrencyCodeOfTheFreightOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? CurrencyCodeOfTheInsuranceOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? CurrencyCodeOfTheInvoiceOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? CurrencyCodeOfTheOtherCostsOfTheArticle { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExchangeRateOfTheDeductionOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExchangeRateOfTheFreightOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExchangeRateOfTheInsuranceOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExchangeRateOfTheInvoiceOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? ExchangeRateOfTheOtherCostsOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? UnitAmountOfTheFairValueOfTheArticle { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

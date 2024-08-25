using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ArticlesSubmittedForVerifications")]
public class ArticlesSubmittedForVerificationDbModel
{
    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    public List<CommonVerificationDbModel>? CommonVerifications { get; set; } =
        new List<CommonVerificationDbModel>();

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredAdditionalFeesAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredAdditionalFeesAmountOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? DeclaredAdditionalFeesCurrencyCodeOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredAdditionalFeesExchangeRateOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? DeclaredApcCode { get; set; }

    [StringLength(1000)]
    public string? DeclaredCountryOfOriginCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredDeductedAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredDeductedAmountOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? DeclaredDeductedCurrencyCodeOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredDeductionExchangeRateOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? DeclaredEvaluationMethodCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredFreightAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredFreightAmountOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? DeclaredFreightCurrencyCodeOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredFreightExchangeRateOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredGrossWeightOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredInsuranceAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredInsuranceAmountOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? DeclaredInsuranceCurrencyCodeOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredInsuranceExchangeRateOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredInvoiceAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredInvoiceAmountInUsdOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredInvoiceAmountOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? DeclaredInvoiceCurrencyCodeOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredInvoiceExchangeRateOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredNetWeightOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? DeclaredPreferentialCode { get; set; }

    [StringLength(1000)]
    public string? DeclaredShCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredTaxableBaseAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredTaxableBaseAmountInUsdOfTheArticle { get; set; }

    public DateTime? DeletedOn { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InitialRecorderId { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedAdditionalFeesAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedAdditionalFeesAmountOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? LiquidatedAdditionalFeesCurrencyCodeOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedAdditionalFeesExchangeRateOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? LiquidatedApcCode { get; set; }

    [StringLength(1000)]
    public string? LiquidatedCountryOfOriginCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedDeductedAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedDeductedAmountOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? LiquidatedDeductedCurrencyCodeOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedDeductionExchangeRateOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? LiquidatedEvaluationMethodCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedFreightAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedFreightAmountOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? LiquidatedFreightCurrencyCodeOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedFreightExchangeRateOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedInsuranceAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedInsuranceAmountOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? LiquidatedInsuranceCurrencyCodeOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedInsuranceExchangeRateOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedInvoiceAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedInvoiceAmountInUsdOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedInvoiceAmountOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? LiquidatedInvoiceCurrencyCodeOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedInvoiceExchangeRateOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedNetWeightOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? LiquidatedPreferentialCode { get; set; }

    [StringLength(1000)]
    public string? LiquidatedShCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedTaxableBaseAmountInNcyOfTheArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidatedTaxableBaseAmountInUsdOfTheArticle { get; set; }

    [StringLength(1000)]
    public string? NumberOfTimesOfValueEvaluation { get; set; }

    public List<TaxForVerificationDbModel>? TaxesForVerification { get; set; } =
        new List<TaxForVerificationDbModel>();

    [Range(-999999999, 999999999)]
    public double? TotalLiquidatedWeightOfTheArticle { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

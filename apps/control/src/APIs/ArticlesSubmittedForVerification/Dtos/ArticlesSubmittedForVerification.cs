namespace Control.APIs.Dtos;

public class ArticlesSubmittedForVerification
{
    public string? ArticleNumber { get; set; }

    public List<string>? CommonVerifications { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public double? DeclaredAdditionalFeesAmountInNcyOfTheArticle { get; set; }

    public double? DeclaredAdditionalFeesAmountOfTheArticle { get; set; }

    public string? DeclaredAdditionalFeesCurrencyCodeOfTheArticle { get; set; }

    public double? DeclaredAdditionalFeesExchangeRateOfTheArticle { get; set; }

    public string? DeclaredApcCode { get; set; }

    public string? DeclaredCountryOfOriginCode { get; set; }

    public double? DeclaredDeductedAmountInNcyOfTheArticle { get; set; }

    public double? DeclaredDeductedAmountOfTheArticle { get; set; }

    public string? DeclaredDeductedCurrencyCodeOfTheArticle { get; set; }

    public double? DeclaredDeductionExchangeRateOfTheArticle { get; set; }

    public string? DeclaredEvaluationMethodCode { get; set; }

    public double? DeclaredFreightAmountInNcyOfTheArticle { get; set; }

    public double? DeclaredFreightAmountOfTheArticle { get; set; }

    public string? DeclaredFreightCurrencyCodeOfTheArticle { get; set; }

    public double? DeclaredFreightExchangeRateOfTheArticle { get; set; }

    public double? DeclaredGrossWeightOfTheArticle { get; set; }

    public double? DeclaredInsuranceAmountInNcyOfTheArticle { get; set; }

    public double? DeclaredInsuranceAmountOfTheArticle { get; set; }

    public string? DeclaredInsuranceCurrencyCodeOfTheArticle { get; set; }

    public double? DeclaredInsuranceExchangeRateOfTheArticle { get; set; }

    public double? DeclaredInvoiceAmountInNcyOfTheArticle { get; set; }

    public double? DeclaredInvoiceAmountInUsdOfTheArticle { get; set; }

    public double? DeclaredInvoiceAmountOfTheArticle { get; set; }

    public string? DeclaredInvoiceCurrencyCodeOfTheArticle { get; set; }

    public double? DeclaredInvoiceExchangeRateOfTheArticle { get; set; }

    public double? DeclaredNetWeightOfTheArticle { get; set; }

    public string? DeclaredPreferentialCode { get; set; }

    public string? DeclaredShCode { get; set; }

    public double? DeclaredTaxableBaseAmountInNcyOfTheArticle { get; set; }

    public double? DeclaredTaxableBaseAmountInUsdOfTheArticle { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? FinalModifierId { get; set; }

    public string Id { get; set; }

    public string? InitialRecorderId { get; set; }

    public double? LiquidatedAdditionalFeesAmountInNcyOfTheArticle { get; set; }

    public double? LiquidatedAdditionalFeesAmountOfTheArticle { get; set; }

    public string? LiquidatedAdditionalFeesCurrencyCodeOfTheArticle { get; set; }

    public double? LiquidatedAdditionalFeesExchangeRateOfTheArticle { get; set; }

    public string? LiquidatedApcCode { get; set; }

    public string? LiquidatedCountryOfOriginCode { get; set; }

    public double? LiquidatedDeductedAmountInNcyOfTheArticle { get; set; }

    public double? LiquidatedDeductedAmountOfTheArticle { get; set; }

    public string? LiquidatedDeductedCurrencyCodeOfTheArticle { get; set; }

    public double? LiquidatedDeductionExchangeRateOfTheArticle { get; set; }

    public string? LiquidatedEvaluationMethodCode { get; set; }

    public double? LiquidatedFreightAmountInNcyOfTheArticle { get; set; }

    public double? LiquidatedFreightAmountOfTheArticle { get; set; }

    public string? LiquidatedFreightCurrencyCodeOfTheArticle { get; set; }

    public double? LiquidatedFreightExchangeRateOfTheArticle { get; set; }

    public double? LiquidatedInsuranceAmountInNcyOfTheArticle { get; set; }

    public double? LiquidatedInsuranceAmountOfTheArticle { get; set; }

    public string? LiquidatedInsuranceCurrencyCodeOfTheArticle { get; set; }

    public double? LiquidatedInsuranceExchangeRateOfTheArticle { get; set; }

    public double? LiquidatedInvoiceAmountInNcyOfTheArticle { get; set; }

    public double? LiquidatedInvoiceAmountInUsdOfTheArticle { get; set; }

    public double? LiquidatedInvoiceAmountOfTheArticle { get; set; }

    public string? LiquidatedInvoiceCurrencyCodeOfTheArticle { get; set; }

    public double? LiquidatedInvoiceExchangeRateOfTheArticle { get; set; }

    public double? LiquidatedNetWeightOfTheArticle { get; set; }

    public string? LiquidatedPreferentialCode { get; set; }

    public string? LiquidatedShCode { get; set; }

    public double? LiquidatedTaxableBaseAmountInNcyOfTheArticle { get; set; }

    public double? LiquidatedTaxableBaseAmountInUsdOfTheArticle { get; set; }

    public List<string>? ModelValueEvaluationVerifications { get; set; }

    public string? NumberOfTimesOfValueEvaluation { get; set; }

    public List<string>? TaxesForVerification { get; set; }

    public double? TotalLiquidatedWeightOfTheArticle { get; set; }

    public DateTime UpdatedAt { get; set; }
}

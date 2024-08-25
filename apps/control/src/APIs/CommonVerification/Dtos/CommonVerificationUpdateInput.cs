using Control.Core.Enums;

namespace Control.APIs.Dtos;

public class CommonVerificationUpdateInput
{
    public double? AdditionalFeesAmountDeclared { get; set; }

    public double? AdditionalFeesAmountFinal { get; set; }

    public double? AdditionalFeesAmountInNcyDeclared { get; set; }

    public double? AdditionalFeesAmountInNcyFinal { get; set; }

    public string? AdditionalFeesCurrencyCodeDeclared { get; set; }

    public string? AdditionalFeesCurrencyCodeFinal { get; set; }

    public double? AdditionalFeesExchangeRateDeclared { get; set; }

    public double? AdditionalFeesExchangeRateFinal { get; set; }

    public double? AdditionalLiquidCommissions { get; set; }

    public double? AdditionalPayableFeesDeclared { get; set; }

    public string? Appeal { get; set; }

    public string? ArticlesSubmittedForVerification { get; set; }

    public List<string>? ContainerValueAssessments { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public double? DeductedAmountDeclared { get; set; }

    public double? DeductedAmountFinal { get; set; }

    public double? DeductedAmountInCnyFinal { get; set; }

    public double? DeductedAmountInNcyDeclared { get; set; }

    public string? DeductedCurrencyCodeDeclared { get; set; }

    public string? DeductedCurrencyCodeFinal { get; set; }

    public double? DeductionExchangeRateDeclared { get; set; }

    public double? DeductionExchangeRateFinal { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? EpcCodeDeclared { get; set; }

    public string? EpcCodeFinal { get; set; }

    public string? FinalModifierId { get; set; }

    public DateTime? FinalOn { get; set; }

    public double? FreightAmountDeclared { get; set; }

    public double? FreightAmountFinal { get; set; }

    public double? FreightAmountInNcyDeclared { get; set; }

    public double? FreightAmountInNcyFinal { get; set; }

    public string? FreightCurrencyCodeDeclared { get; set; }

    public string? FreightCurrencyCodeFinal { get; set; }

    public double? FreightExchangeRateDeclared { get; set; }

    public double? FreightExchangeRateFinal { get; set; }

    public string? Id { get; set; }

    public string? ImporterIdentificationNumberDeclared { get; set; }

    public string? ImporterIdentificationNumberFinal { get; set; }

    public string? ImporterIdentificationTypeCodeDeclared { get; set; }

    public string? ImporterIdentificationTypeCodeFinal { get; set; }

    public string? InitialRecorderId { get; set; }

    public double? InsuranceAmountDeclared { get; set; }

    public double? InsuranceAmountFinal { get; set; }

    public double? InsuranceAmountInNcyDeclared { get; set; }

    public double? InsuranceAmountInNcyFinal { get; set; }

    public string? InsuranceCurrencyCodeDeclared { get; set; }

    public string? InsuranceCurrencyCodeFinal { get; set; }

    public double? InsuranceExchangeRateDeclared { get; set; }

    public double? InsuranceExchangeRateFinal { get; set; }

    public double? InvalidSecurityAmountDeclared { get; set; }

    public double? InvalidSecurityAmountFinal { get; set; }

    public double? InvoiceAmountDeclared { get; set; }

    public double? InvoiceAmountFinal { get; set; }

    public double? InvoiceAmountInNcyDeclared { get; set; }

    public double? InvoiceAmountInNcyFinal { get; set; }

    public double? InvoiceAmountInUsdFinal { get; set; }

    public string? InvoiceCurrencyCodeDeclared { get; set; }

    public string? InvoiceCurrencyCodeFinal { get; set; }

    public double? InvoiceExchangeRateDeclared { get; set; }

    public double? InvoiceExchangeRateFinal { get; set; }

    public string? NiuFinal { get; set; }

    public double? ReducedValidSecurityAmountDeclared { get; set; }

    public double? ReducedValidSecurityAmountFinal { get; set; }

    public string? ResultOfVerificationOfDetailedDeclaration { get; set; }

    public List<string>? TaxesForVerification { get; set; }

    public string? TaxpayerIdentificationNumberDeclared { get; set; }

    public double? TotalDeclaredTaxes { get; set; }

    public double? TotalFinalTaxes { get; set; }

    public double? TotalPaidTaxesDeclared { get; set; }

    public double? TotalPaidTaxesFinal { get; set; }

    public double? TotalTaxableAmountInNcyDeclared { get; set; }

    public double? TotalTaxableAmountInNcyFinal { get; set; }

    public double? TotalTaxableAmountInUsdDeclared { get; set; }

    public double? TotalTaxableAmountInUsdFinal { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public double? ValidSecurityAmountDeclared { get; set; }

    public double? ValidSecurityAmountFinal { get; set; }

    public ValueEvaluationStatusCodeEnum? ValueEvaluationStatusCode { get; set; }

    public string? VerificationResult { get; set; }
}

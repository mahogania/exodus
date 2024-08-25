using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Control.Core.Enums;

namespace Control.Infrastructure.Models;

[Table("CommonVerifications")]
public class CommonVerificationDbModel
{
    [Range(-999999999, 999999999)]
    public double? AdditionalFeesAmountDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalFeesAmountFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalFeesAmountInNcyDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalFeesAmountInNcyFinal { get; set; }

    [StringLength(1000)]
    public string? AdditionalFeesCurrencyCodeDeclared { get; set; }

    [StringLength(1000)]
    public string? AdditionalFeesCurrencyCodeFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalFeesExchangeRateDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalFeesExchangeRateFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalLiquidCommissions { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalPayableFeesDeclared { get; set; }

    public string? AppealId { get; set; }

    [ForeignKey(nameof(AppealId))]
    public AppealDbModel? Appeal { get; set; } = null;

    public string? ArticlesSubmittedForVerificationId { get; set; }

    [ForeignKey(nameof(ArticlesSubmittedForVerificationId))]
    public ArticlesSubmittedForVerificationDbModel? ArticlesSubmittedForVerification { get; set; } =
        null;

    public List<ContainerValueAssessmentDbModel>? ContainerValueAssessments { get; set; } =
        new List<ContainerValueAssessmentDbModel>();

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductedAmountDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductedAmountFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductedAmountInCnyFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductedAmountInNcyDeclared { get; set; }

    [StringLength(1000)]
    public string? DeductedCurrencyCodeDeclared { get; set; }

    [StringLength(1000)]
    public string? DeductedCurrencyCodeFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductionExchangeRateDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductionExchangeRateFinal { get; set; }

    public DateTime? DeletedOn { get; set; }

    [StringLength(1000)]
    public string? EpcCodeDeclared { get; set; }

    [StringLength(1000)]
    public string? EpcCodeFinal { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    public DateTime? FinalOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? FreightAmountDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? FreightAmountFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? FreightAmountInNcyDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? FreightAmountInNcyFinal { get; set; }

    [StringLength(1000)]
    public string? FreightCurrencyCodeDeclared { get; set; }

    [StringLength(1000)]
    public string? FreightCurrencyCodeFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? FreightExchangeRateDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? FreightExchangeRateFinal { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ImporterIdentificationNumberDeclared { get; set; }

    [StringLength(1000)]
    public string? ImporterIdentificationNumberFinal { get; set; }

    [StringLength(1000)]
    public string? ImporterIdentificationTypeCodeDeclared { get; set; }

    [StringLength(1000)]
    public string? ImporterIdentificationTypeCodeFinal { get; set; }

    [StringLength(1000)]
    public string? InitialRecorderId { get; set; }

    [Range(-999999999, 999999999)]
    public double? InsuranceAmountDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? InsuranceAmountFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? InsuranceAmountInNcyDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? InsuranceAmountInNcyFinal { get; set; }

    [StringLength(1000)]
    public string? InsuranceCurrencyCodeDeclared { get; set; }

    [StringLength(1000)]
    public string? InsuranceCurrencyCodeFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? InsuranceExchangeRateDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? InsuranceExchangeRateFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvalidSecurityAmountDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvalidSecurityAmountFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceAmountDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceAmountFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceAmountInNcyDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceAmountInNcyFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceAmountInUsdFinal { get; set; }

    [StringLength(1000)]
    public string? InvoiceCurrencyCodeDeclared { get; set; }

    [StringLength(1000)]
    public string? InvoiceCurrencyCodeFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceExchangeRateDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceExchangeRateFinal { get; set; }

    [StringLength(1000)]
    public string? NiuFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? ReducedValidSecurityAmountDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? ReducedValidSecurityAmountFinal { get; set; }

    [StringLength(1000)]
    public string? ResultOfVerificationOfDetailedDeclaration { get; set; }

    public List<TaxForVerificationDbModel>? TaxesForVerification { get; set; } =
        new List<TaxForVerificationDbModel>();

    [StringLength(1000)]
    public string? TaxpayerIdentificationNumberDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalDeclaredTaxes { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalFinalTaxes { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalPaidTaxesDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalPaidTaxesFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalTaxableAmountInNcyDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalTaxableAmountInNcyFinal { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalTaxableAmountInUsdDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalTaxableAmountInUsdFinal { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? ValidSecurityAmountDeclared { get; set; }

    [Range(-999999999, 999999999)]
    public double? ValidSecurityAmountFinal { get; set; }

    public ValueEvaluationStatusCodeEnum? ValueEvaluationStatusCode { get; set; }

    public VerificationResultDbModel? VerificationResult { get; set; } = null;
}

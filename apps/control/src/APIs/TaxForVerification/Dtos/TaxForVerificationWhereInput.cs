namespace Control.APIs.Dtos;

public class TaxForVerificationWhereInput
{
    public string? ArticleNumber { get; set; }

    public string? ArticlesSubmittedForVerifications { get; set; }

    public double? BasicTaxAmount { get; set; }

    public double? BasicTaxRate { get; set; }

    public double? BasicTaxableAmount { get; set; }

    public List<string>? CommonVerifications { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public DateTime? DeletedOn { get; set; }

    public double? ExemptedAmount { get; set; }

    public double? ExemptedTaxRate { get; set; }

    public double? ExemptionBaseAmount { get; set; }

    public string? ExemptionTypeCode { get; set; }

    public string? FinalModifierId { get; set; }

    public string? Id { get; set; }

    public string? InitialRecorderId { get; set; }

    public string? NumberOfTimesOfValueEvaluation { get; set; }

    public double? PaidTaxAmount { get; set; }

    public string? PaymentTypeCode { get; set; }

    public double? SecurityDepositAfterExemption { get; set; }

    public string? TariffCategoryCode { get; set; }

    public double? TaxAmount { get; set; }

    public double? TaxBaseAmount { get; set; }

    public string? TaxBenefitCode { get; set; }

    public string? TaxCode { get; set; }

    public double? TaxRate { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

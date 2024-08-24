namespace Control.APIs.Dtos;

public class ValueAssessmentUpdateInput
{
    public List<string>? Articles { get; set; }

    public string? CommonDetailedDeclarations { get; set; }

    public DateTime? CreatedAt { get; set; }

    public double? DeductedAmount { get; set; }

    public string? DeductionCurrencyCode { get; set; }

    public double? DeductionExchangeRate { get; set; }

    public double? DeductionNcyAmount { get; set; }

    public DateTime? FinalModificationDateTime { get; set; }

    public int? FinalModifierId { get; set; }

    public int? FirstRecorderId { get; set; }

    public DateTime? FirstRecordingDateTime { get; set; }

    public double? FreightAmount { get; set; }

    public string? FreightCurrencyCode { get; set; }

    public double? FreightExchangeRate { get; set; }

    public double? FreightNcyAmount { get; set; }

    public string? Id { get; set; }

    public double? InsuranceAmount { get; set; }

    public string? InsuranceCurrencyCode { get; set; }

    public double? InsuranceExchangeRate { get; set; }

    public double? InsuranceNcyAmount { get; set; }

    public double? InvoiceAmount { get; set; }

    public double? InvoiceExchangeRate { get; set; }

    public double? InvoiceNcyAmount { get; set; }

    public double? InvoiceUsdAmount { get; set; }

    public double? OtherCostsAmount { get; set; }

    public string? OtherCostsCurrencyCode { get; set; }

    public double? OtherCostsExchangeRate { get; set; }

    public double? OtherCostsNcyAmount { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public double? TotalTaxableBaseNcyTotal { get; set; }

    public double? TotalTaxableBaseUsdTotal { get; set; }

    public double? TotalValueAssessmentNcyAmount { get; set; }

    public double? TotalValueAssessmentUsdAmount { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

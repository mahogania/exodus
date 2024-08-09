namespace Clre.APIs.Dtos;

public class CustomsDetailedDeclarationTaxWhereInput
{
    public string? ArticleNumber { get; set; }

    public double? BasicTaxAmount { get; set; }

    public double? BasicTaxableBaseAmount { get; set; }

    public double? BasicTaxationRate { get; set; }

    public double? CautionAmountAfterExemptionOfGuarantee { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public double? ExemptAmount { get; set; }

    public double? ExemptTaxationRate { get; set; }

    public double? ExemptionBaseAmount { get; set; }

    public string? ExemptionTypeCode { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? Id { get; set; }

    public string? IdDuPremierEnregistrant { get; set; }

    public double? PaidTaxAmount { get; set; }

    public string? PaymentTypeCode { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? SuppressionOn { get; set; }

    public string? TariffCategoryCode { get; set; }

    public string? TaxAdvantageCode { get; set; }

    public double? TaxAmount { get; set; }

    public string? TaxCode { get; set; }

    public double? TaxableBaseAmount { get; set; }

    public double? TaxationRate { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

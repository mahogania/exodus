namespace Control.APIs.Dtos;

public class MaterialsAtWithReexportationInTheStateUpdateInput
{
    public string? CommercialDesignationOfTheMaterials { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public double? FobValueInCurrency { get; set; }

    public double? FobValueInDa { get; set; }

    public string? Id { get; set; }

    public string? Identification { get; set; }

    public string? Origin { get; set; }

    public double? Quantity { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public double? SequenceNumber { get; set; }

    public string? SptNumber { get; set; }

    public string? StateOfTheMaterialsAtTheTimeOfImportation { get; set; }

    public string? SuppressionOn { get; set; }

    public string? TechnicalDesignationOfTheMaterials { get; set; }

    public double? UnknownField { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

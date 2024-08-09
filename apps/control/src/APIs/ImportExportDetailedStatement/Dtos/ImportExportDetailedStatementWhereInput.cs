namespace Control.APIs.Dtos;

public class ImportExportDetailedStatementWhereInput
{
    public double? Amount { get; set; }

    public string? BrandName { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DocumentCode { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? Id { get; set; }

    public string? ImportExportTypeCode { get; set; }

    public string? OriginCountryCode { get; set; }

    public double? Quantity { get; set; }

    public string? QuantityUnitCode { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public double? SequenceNumber { get; set; }

    public string? ShCode { get; set; }

    public string? SuppressionOn { get; set; }

    public string? TechniqueName { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

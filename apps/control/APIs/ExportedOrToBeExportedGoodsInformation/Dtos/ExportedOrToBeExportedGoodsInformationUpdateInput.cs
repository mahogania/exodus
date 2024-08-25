namespace Control.APIs.Dtos;

public class ExportedOrToBeExportedGoodsInformationUpdateInput
{
    public string? ArticleNumber { get; set; }

    public string? CommercialDesignationOfTheGoods { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DestinationCountry { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? Id { get; set; }

    public double? Quantity { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public double? SequenceNumber { get; set; }

    public string? SptNumber { get; set; }

    public string? SuppressionOn { get; set; }

    public string? TechnicalDesignationOfTheGoods { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public double? Value { get; set; }
}

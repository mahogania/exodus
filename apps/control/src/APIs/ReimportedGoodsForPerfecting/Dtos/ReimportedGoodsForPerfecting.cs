namespace Control.APIs.Dtos;

public class ReimportedGoodsForPerfecting
{
    public string? CommercialDesignationOfGoods { get; set; }

    public string? CountryOfImportation { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DeletionOn { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public double? FobValue { get; set; }

    public string Id { get; set; }

    public string? NatureOfGoodsRemainingOutsideTheCustomsTerritory { get; set; }

    public string? Origin { get; set; }

    public double? Quantity { get; set; }

    public double? QuantityOfEachGoodRemainingOutsideTheCustomsTerritory { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public double? SequenceNumber { get; set; }

    public string? SptNumber { get; set; }

    public string? TechnicalDesignationOfGoods { get; set; }

    public DateTime UpdatedAt { get; set; }
}

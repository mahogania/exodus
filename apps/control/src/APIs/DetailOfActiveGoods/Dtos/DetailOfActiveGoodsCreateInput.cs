namespace Control.APIs.Dtos;

public class DetailOfActiveGoodsCreateInput
{
    public string? BrandName { get; set; }

    public string? CodeOfImportExportType { get; set; }

    public CommonActiveGoodsRequest? CommonActiveGoodsRequest { get; set; }

    public string? CountryOfOriginCode { get; set; }

    public string? CountryOfShipmentCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DeletionOn { get; set; }

    public string? DocumentCode { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public double? GoodsValue { get; set; }

    public string? Id { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public double? SequenceNumber { get; set; }

    public string? ShCode { get; set; }

    public double? StorageLocation { get; set; }

    public string? StorageLocationUnitCode { get; set; }

    public string? TransactionValueCurrencyCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}

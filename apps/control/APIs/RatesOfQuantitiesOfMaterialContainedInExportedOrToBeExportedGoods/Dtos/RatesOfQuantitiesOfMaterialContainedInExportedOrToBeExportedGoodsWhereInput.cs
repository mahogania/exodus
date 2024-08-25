namespace Control.APIs.Dtos;

public class RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? Id { get; set; }

    public double? RatesOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheNationalMarket { get; set; }

    public double? RatesOfQuantitiesOfImportedMaterials { get; set; }

    public double? RatesOfQuantitiesOfImportedPackaging { get; set; }

    public double? RatesOfQuantitiesOfNationalOriginMaterials { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public double? SequenceNumber { get; set; }

    public string? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

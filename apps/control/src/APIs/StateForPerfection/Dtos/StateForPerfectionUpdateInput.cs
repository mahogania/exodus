namespace Control.APIs.Dtos;

public class StateForPerfectionUpdateInput
{
    public string? AddressOfTheDomiciliaryBank { get; set; }

    public string? CorporateNameOfTheDomiciliaryBank { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CustomsOfficeAtExportation { get; set; }

    public string? CustomsOfficeAtImportation { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FinancingModeOfTheOperation { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? Id { get; set; }

    public string? NatureOfTheOperation { get; set; }

    public double? RateOfLosses { get; set; }

    public double? RateOfNonRecoverableWaste { get; set; }

    public double? RateOfQuantitiesOfExportedMaterials { get; set; }

    public double? RateOfQuantitiesOfExportedPackaging { get; set; }

    public double? RateOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheForeignMarket { get; set; }

    public double? RateOfRecoverableWaste { get; set; }

    public double? RateOfWasteOnFinishedProducts { get; set; }

    public string? RecipientSAddress { get; set; }

    public string? RecipientSCorporateName { get; set; }

    public string? RecipientSName { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public string? RequestedEndDate { get; set; }

    public string? RequestedStartDate { get; set; }

    public string? SuppressionOn { get; set; }

    public double? TotalAmountForeseenForTransformationRepair { get; set; }

    public string? TypeOfActivePerfectionSolicited { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

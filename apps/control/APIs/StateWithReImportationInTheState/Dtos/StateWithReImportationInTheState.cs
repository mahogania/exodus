namespace Control.APIs.Dtos;

public class StateWithReImportationInTheState
{
    public string? Address { get; set; }

    public string? ContractObject { get; set; }

    public string? ContractReference { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CustomsOfficeForReImportationIndicative { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? ExportingCountryCode { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? ForeignRecipient { get; set; }

    public string Id { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public string? RequestedEndDateOfTemporaryExport { get; set; }

    public string? RequestedStartDateOfTemporaryExport { get; set; }

    public string? SuppressionOn { get; set; }

    public string? UnknownFieldOne { get; set; }

    public string? UnknownFieldTwo { get; set; }

    public DateTime UpdatedAt { get; set; }
}

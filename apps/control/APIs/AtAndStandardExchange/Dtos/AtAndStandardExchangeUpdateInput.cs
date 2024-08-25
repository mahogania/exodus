namespace Control.APIs.Dtos;

public class AtAndStandardExchangeUpdateInput
{
    public DateTime? CreatedAt { get; set; }

    public string? CustomsClearanceOfficeForAtEt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DateOfTheImportationDeclaration { get; set; }

    public string? DeclarationNumber { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? Id { get; set; }

    public string? ImportationDeclarationCode { get; set; }

    public string? ReasonForTheRequest { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public string? RequestStatus { get; set; }

    public string? RequestedEndDate { get; set; }

    public string? RequestedStartDate { get; set; }

    public string? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? WarrantyEndDate { get; set; }

    public string? WarrantyFrame { get; set; }
}

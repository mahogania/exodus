namespace Clre.APIs.Dtos;

public class TemporaryAdmissionOfVehicleUpdateInput
{
    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public string? EntryCustomsOfficeCode { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? ReImportationReExportationOfficeCode { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public string? RequestedDelayEndDate { get; set; }

    public string? RequestedDelayStartDate { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

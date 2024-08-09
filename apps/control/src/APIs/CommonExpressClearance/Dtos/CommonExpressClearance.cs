namespace Control.APIs.Dtos;

public class CommonExpressClearance
{
    public string? ArrivalDate { get; set; }

    public string? AttachedFileId { get; set; }

    public string? CountryOfLoadingCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CustomsOfficeCode { get; set; }

    public string? DeletionOn { get; set; }

    public string? ExpressClearanceRequestNumber { get; set; }

    public string? ExpressOperatorCode { get; set; }

    public string? ExpressOperatorName { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string Id { get; set; }

    public string? MasterBlNumber { get; set; }

    public string? RequestDate { get; set; }

    public string? ShipName { get; set; }

    public string? TransmissionTypeCode { get; set; }

    public string? TreatmentStatusCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}

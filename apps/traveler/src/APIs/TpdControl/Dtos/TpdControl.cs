namespace Traveler.APIs.Dtos;

public class TpdControl
{
    public string? ApprovalId { get; set; }

    public string? ApprovalProcessStatusCode { get; set; }

    public string? BaggageControlArticle { get; set; }

    public string? ControlResult { get; set; }

    public DateTime? ControlResultRegistrationDateTime { get; set; }

    public string? ControlStatus { get; set; }

    public string? ControlTypeCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<string>? GeneralTravelerInformationTpds { get; set; }

    public string Id { get; set; }

    public List<string>? ImportDeclarations { get; set; }

    public string? InspectorId { get; set; }

    public double? JudgmentOrder { get; set; }

    public string? TpdNumber { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? VerificationResultCode { get; set; }

    public string? VerificationResultContent { get; set; }
}

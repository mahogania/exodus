namespace Control.APIs.Dtos;

public class ForeignOperatorRequestCreateInput
{
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DeletionOn { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public string? ForeignOperatorAddress { get; set; }

    public string? ForeignOperatorCityCode { get; set; }

    public string? ForeignOperatorCode { get; set; }

    public string? ForeignOperatorCompanyName { get; set; }

    public string? ForeignOperatorCountryCode { get; set; }

    public string? ForeignOperatorEmail { get; set; }

    public string? ForeignOperatorPhoneNumber { get; set; }

    public string? ForeignOperatorRepresentativeName { get; set; }

    public string? ForeignOperatorRequestNumber { get; set; }

    public string? Id { get; set; }

    public string? ProcessingDate { get; set; }

    public string? ProcessingStatusCode { get; set; }

    public string? RequestDate { get; set; }

    public string? RequestReasonContent { get; set; }

    public string? RequestTypeCode { get; set; }

    public string? RequestingPersonId { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? VerificationOpinionContent { get; set; }
}

namespace Control.APIs.Dtos;

public class VerificationResultWhereInput
{
    public string? CommonVerification { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? FinalModifierId { get; set; }

    public string? Id { get; set; }

    public string? InitialRecorderId { get; set; }

    public string? InspectorId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? VerificationCompletedOn { get; set; }

    public string? VerificationResultContent { get; set; }

    public List<string>? VerificationResultDetails { get; set; }

    public DateTime? VerificationResultRecordDate { get; set; }
}

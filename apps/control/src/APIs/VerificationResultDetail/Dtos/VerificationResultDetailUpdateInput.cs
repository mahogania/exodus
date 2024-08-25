namespace Control.APIs.Dtos;

public class VerificationResultDetailUpdateInput
{
    public string? AlignmentOrder { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public DateTime? DeletedOn { get; set; }

    public string? FinalModifierId { get; set; }

    public string? Id { get; set; }

    public string? InitialRecorderId { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? VerificationResult { get; set; }

    public string? VerificationResultCode { get; set; }
}

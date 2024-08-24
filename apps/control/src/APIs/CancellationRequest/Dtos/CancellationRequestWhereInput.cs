namespace Control.APIs.Dtos;

public class CancellationRequestWhereInput
{
    public string? CancellationContent { get; set; }

    public string? CancellationReasonCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DateOfRequestForCancellation { get; set; }

    public string? FinalOn { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? Id { get; set; }

    public string? IdOfTheAttachedFile { get; set; }

    public double? NumberOfCancellations { get; set; }

    public string? ProcessingStatusCode { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? Request { get; set; }

    public string? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

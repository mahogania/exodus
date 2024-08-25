namespace Traveler.APIs.Dtos;

public class InspectorRatingModificationHistoryUpdateInput
{
    public string? AuditorClassificationCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DistributionContent { get; set; }

    public string? DistributionReasonCode { get; set; }

    public string? ExaminerIdAfterModification { get; set; }

    public string? ExaminerIdBeforeChange { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<string>? GeneralTravelerInformationTpds { get; set; }

    public double? HistorySequenceNumber { get; set; }

    public string? Id { get; set; }

    public string? ReferenceNumber { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

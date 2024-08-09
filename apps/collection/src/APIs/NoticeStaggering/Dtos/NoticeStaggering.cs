namespace Collection.APIs.Dtos;

public class NoticeStaggering
{
    public string? AttachmentId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string Id { get; set; }

    public string? NoticeNo { get; set; }

    public double? NumberOfStaggeredNotices { get; set; }

    public string? OfficeCode { get; set; }

    public string? RegisteringPersonId { get; set; }

    public string? ServiceCode { get; set; }

    public string? StaggeredNoticesGroupingDate { get; set; }

    public string? StaggeredNoticesGroupingPersonId { get; set; }

    public string? StaggeredNoticesGroupingReasonContent { get; set; }

    public string? StaggeringDate { get; set; }

    public string? StaggeringReasonContent { get; set; }

    public DateTime UpdatedAt { get; set; }
}

namespace Collection.APIs.Dtos;

public class FineCancellationRequestUpdateInput
{
    public string? ApprovalId { get; set; }

    public string? AttachmentId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FineCancellationReasonContent { get; set; }

    public string? FineCancellationRequestNo { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? NoticeNo { get; set; }

    public string? OfficeCode { get; set; }

    public string? RequestDate { get; set; }

    public string? RequestingPersonId { get; set; }

    public string? ServiceCode { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

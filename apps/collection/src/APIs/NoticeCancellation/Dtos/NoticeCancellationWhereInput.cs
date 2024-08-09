namespace Collection.APIs.Dtos;

public class NoticeCancellationWhereInput
{
    public string? AttachmentId { get; set; }

    public string? CancellationDate { get; set; }

    public string? CancellationReasonContent { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? NoticeCancellationRequestNo { get; set; }

    public string? NoticeNo { get; set; }

    public string? OfficeCode { get; set; }

    public string? RegisteringPersonId { get; set; }

    public string? RegistrationDate { get; set; }

    public double? RequestOrderNo { get; set; }

    public string? ServiceCode { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

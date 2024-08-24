namespace Control.APIs.Dtos;

public class ArticleCarnetControl
{
    public string? ArticleNumber { get; set; }

    public string? AttachmentFileId { get; set; }

    public DateTime? AuthorizationDate { get; set; }

    public string? CarnetNumber { get; set; }

    public string? CarnetTypeCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CustomsNote { get; set; }

    public DateTime? DeletedOn { get; set; }

    public DateTime? FirstRecordDateAndTime { get; set; }

    public string? FirstRecorderId { get; set; }

    public string Id { get; set; }

    public DateTime? LastModificationDateAndTime { get; set; }

    public string? LastModifierId { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public string? OperationTypeCode { get; set; }

    public string? ProcessingStatusCode { get; set; }

    public string? ReferenceNo { get; set; }

    public DateTime UpdatedAt { get; set; }
}

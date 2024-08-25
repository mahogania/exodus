namespace Control.APIs.Dtos;

public class AnalysisRequest
{
    public string? AnalysisExpertiseRequestNumber { get; set; }

    public string? ArticleNumber { get; set; }

    public string? AttachedFileId { get; set; }

    public string? ControlInstitutionName { get; set; }

    public DateTime? ControlProcessingDateTime { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DetailedDeclarationNumber { get; set; }

    public string Id { get; set; }

    public string? InspectorName { get; set; }

    public bool? NotificationOn { get; set; }

    public string? Procedure { get; set; }

    public string? ProcessingStatusCode { get; set; }

    public string? RequestContents { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? RequestTypeCode { get; set; }

    public string? RequesterId { get; set; }

    public string? SampleRequests { get; set; }

    public string? SealNumber { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? VerificationResultCode { get; set; }

    public string? VerificationResultContents { get; set; }
}

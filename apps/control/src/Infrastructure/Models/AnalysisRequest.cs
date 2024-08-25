using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("AnalysisRequests")]
public class AnalysisRequestDbModel
{
    [StringLength(1000)]
    public string? AnalysisExpertiseRequestNumber { get; set; }

    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    [StringLength(1000)]
    public string? AttachedFileId { get; set; }

    [StringLength(1000)]
    public string? ControlInstitutionName { get; set; }

    public DateTime? ControlProcessingDateTime { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DetailedDeclarationNumber { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InspectorName { get; set; }

    public bool? NotificationOn { get; set; }

    public string? ProcedureId { get; set; }

    [ForeignKey(nameof(ProcedureId))]
    public ProcedureDbModel? Procedure { get; set; } = null;

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? RequestContents { get; set; }

    public DateTime? RequestDate { get; set; }

    [StringLength(1000)]
    public string? RequestTypeCode { get; set; }

    [StringLength(1000)]
    public string? RequesterId { get; set; }

    public SampleRequestDbModel? SampleRequests { get; set; } = null;

    [StringLength(1000)]
    public string? SealNumber { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? VerificationResultCode { get; set; }

    [StringLength(1000)]
    public string? VerificationResultContents { get; set; }
}

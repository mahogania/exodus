using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("SampleRequests")]
public class SampleRequestDbModel
{
    [StringLength(1000)]
    public string? AnalysisExpertiseRequestId { get; set; }

    public string? AnalysisRequestId { get; set; }

    [ForeignKey(nameof(AnalysisRequestId))]
    public AnalysisRequestDbModel? AnalysisRequest { get; set; } = null;

    public string? ArticleId { get; set; }

    [ForeignKey(nameof(ArticleId))]
    public ArticleDbModel? Article { get; set; } = null;

    [StringLength(1000)]
    public string? ArticleName { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeclarantCode { get; set; }

    public bool? DeclarantPresence { get; set; }

    [StringLength(1000)]
    public string? DetailedDeclarationId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public int? Quantity { get; set; }

    [StringLength(1000)]
    public string? RequestTypeId { get; set; }

    [Range(-999999999, 999999999)]
    public int? RestitutedSampleQuantity { get; set; }

    [Range(-999999999, 999999999)]
    public int? RestitutedSampleWeight { get; set; }

    public DateTime? SampleCollectionDate { get; set; }

    public DateTime? SampleCollectionEndDate { get; set; }

    public DateTime? SampleCollectionStartDate { get; set; }

    [StringLength(1000)]
    public string? SampleDescription { get; set; }

    public DateTime? SampleRequestDate { get; set; }

    public bool? SampleRestitution { get; set; }

    public bool? SampleRestitutionConfirmation { get; set; }

    public DateTime? SampleRestitutionDate { get; set; }

    [StringLength(1000)]
    public string? SuspicionResultsContents { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public int? Weight { get; set; }
}

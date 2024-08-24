using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ReexportCarnetControls")]
public class ReexportCarnetControlDbModel
{
    [StringLength(1000)]
    public string? ActionsAgainstArticlesThatCannotBeReexported_1 { get; set; }

    [StringLength(1000)]
    public string? ActionsAgainstArticlesThatCannotBeReexported_2 { get; set; }

    [StringLength(1000)]
    public string? AttachmentFileId { get; set; }

    public DateTime? AuthorizationDate { get; set; }

    [StringLength(1000)]
    public string? CarnetNumber { get; set; }

    [StringLength(1000)]
    public string? CarnetTypeCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DeletedOn { get; set; }

    [StringLength(1000)]
    public string? DestinationOffice { get; set; }

    public DateTime? FirstRecordDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public DateTime? LastModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? LastModifierId { get; set; }

    [StringLength(1000)]
    public string? ManagementNumberOfCarnet { get; set; }

    [StringLength(1000)]
    public string? OtherContents { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    public string? ReexportCarnetRequestsId { get; set; }

    [ForeignKey(nameof(ReexportCarnetRequestsId))]
    public ReexportCarnetRequestDbModel? ReexportCarnetRequests { get; set; } = null;

    [StringLength(1000)]
    public string? ReexportedArticles { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

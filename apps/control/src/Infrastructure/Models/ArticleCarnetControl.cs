using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ArticleCarnetControls")]
public class ArticleCarnetControlDbModel
{
    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    [StringLength(1000)]
    public string? AttachmentFileId { get; set; }

    public DateTime? AuthorizationDate { get; set; }

    [StringLength(1000)]
    public string? CarnetNumber { get; set; }

    [StringLength(1000)]
    public string? CarnetTypeCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsNote { get; set; }

    public DateTime? DeletedOn { get; set; }

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
    public string? OperationTypeCode { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

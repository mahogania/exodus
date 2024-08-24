using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ImportCarnetControls")]
public class ImportCarnetControlDbModel
{
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

    public DateTime? ReExportationDate { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [StringLength(1000)]
    public string? TemporarilyImportedArticles { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

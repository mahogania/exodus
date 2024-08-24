using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ExtendedPeriodCarnetControls")]
public class ExtendedPeriodCarnetControlDbModel
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

    public string? ExtendedPeriodCarnetRequestId { get; set; }

    [ForeignKey(nameof(ExtendedPeriodCarnetRequestId))]
    public ExtendedPeriodCarnetRequestDbModel? ExtendedPeriodCarnetRequest { get; set; } = null;

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
    public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? SequenceNumber { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? VerificationResultContent { get; set; }
}

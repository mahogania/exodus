using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("FineCancellationRequests")]
public class FineCancellationRequestDbModel
{
    [StringLength(1000)]
    public string? ApprovalId { get; set; }

    [StringLength(1000)]
    public string? AttachmentId { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FineCancellationReasonContent { get; set; }

    [StringLength(1000)]
    public string? FineCancellationRequestNo { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? NoticeNo { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? RequestDate { get; set; }

    [StringLength(1000)]
    public string? RequestingPersonId { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

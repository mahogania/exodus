using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("NoticeCancellations")]
public class NoticeCancellationDbModel
{
    [StringLength(1000)]
    public string? AttachmentId { get; set; }

    [StringLength(1000)]
    public string? CancellationDate { get; set; }

    [StringLength(1000)]
    public string? CancellationReasonContent { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? NoticeCancellationRequestNo { get; set; }

    [StringLength(1000)]
    public string? NoticeNo { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? RegisteringPersonId { get; set; }

    [StringLength(1000)]
    public string? RegistrationDate { get; set; }

    [Range(-999999999, 999999999)]
    public double? RequestOrderNo { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

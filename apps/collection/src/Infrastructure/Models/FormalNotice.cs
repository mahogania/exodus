using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("FormalNotices")]
public class FormalNoticeDbModel
{
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

    [StringLength(1000)]
    public string? FormalNoticeNumber { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? InitialApAmount { get; set; }

    [StringLength(1000)]
    public string? LatePaymentDate { get; set; }

    [Range(-999999999, 999999999)]
    public double? LatePaymentInterestAmount { get; set; }

    [StringLength(1000)]
    public string? NoticeNumber { get; set; }

    [StringLength(1000)]
    public string? NotificationDate { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfFormalNotices { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfLatePayments { get; set; }

    [StringLength(1000)]
    public string? PaymentDeadline { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

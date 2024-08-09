using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Delays")]
public class DelayDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionFlag { get; set; }

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
    public string? LatePaymentDate { get; set; }

    [Range(-999999999, 999999999)]
    public double? LatePaymentInterestAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? LatePaymentInterestAmountExistingBeforeLatePayment { get; set; }

    [StringLength(1000)]
    public string? NoticeNumber { get; set; }

    [StringLength(1000)]
    public string? NotificationDate { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfTimesOfLatePayments { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? PaymentDeadline { get; set; }

    [Range(-999999999, 999999999)]
    public double? PenaltyRate { get; set; }

    [StringLength(1000)]
    public string? PreviousDueDate { get; set; }

    [StringLength(1000)]
    public string? PreviousNotificationDate { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalNoticeAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalPreviousNoticeAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? UnadjustedLatePaymentInterestAmount { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

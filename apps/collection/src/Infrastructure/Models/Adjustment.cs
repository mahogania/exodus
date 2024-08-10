using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Adjustments")]
public class AdjustmentDbModel
{
    [StringLength(1000)] public string? AdjustmentDate { get; set; }

    [StringLength(1000)] public string? AdjustmentReasonContent { get; set; }

    [StringLength(1000)] public string? AttachedFileId { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    [StringLength(1000)] public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key] [Required] public string Id { get; set; }

    [Range(-999999999, 999999999)] public double? LatePaymentInterestAmount { get; set; }

    [Range(-999999999, 999999999)] public double? LatePaymentInterestAmountExistingBeforeLatePayment { get; set; }

    [StringLength(1000)] public string? NoticeNumber { get; set; }

    [Range(-999999999, 999999999)] public double? NumberOfAdjustments { get; set; }

    [Range(-999999999, 999999999)] public double? NumberOfLatePayments { get; set; }

    [StringLength(1000)] public string? OfficeCode { get; set; }

    [Range(-999999999, 999999999)] public double? PreviousTotalNoticeAmount { get; set; }

    [StringLength(1000)] public string? RegisteringPersonId { get; set; }

    [StringLength(1000)] public string? ServiceCode { get; set; }

    [Range(-999999999, 999999999)] public double? TotalNoticeAmount { get; set; }

    [Range(-999999999, 999999999)] public double? UnadjustedLatePaymentInterestAmount { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

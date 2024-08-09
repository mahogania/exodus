using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Notices")]
public class NoticeDbModel
{
    [Range(-999999999, 999999999)]
    public double? AmountOfOtherChargeableFees { get; set; }

    [StringLength(1000)]
    public string? BondTypeCode { get; set; }

    [StringLength(1000)]
    public string? CancellationDate { get; set; }

    [StringLength(1000)]
    public string? CancelledOn { get; set; }

    [StringLength(1000)]
    public string? CollectedOn { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeclarantCode { get; set; }

    [StringLength(1000)]
    public string? DeclarationNo { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? ExtendedDeadlineOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FinancialManagerName { get; set; }

    [Range(-999999999, 999999999)]
    public double? FineAmount { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? LateDate { get; set; }

    [StringLength(1000)]
    public string? LateInterestAdjustedYn { get; set; }

    [Range(-999999999, 999999999)]
    public double? LateInterestAmount { get; set; }

    [StringLength(1000)]
    public string? LatePaymentOn { get; set; }

    [StringLength(1000)]
    public string? NiuCategoryCode { get; set; }

    [StringLength(1000)]
    public string? NoticeCancellationReasonCode { get; set; }

    [StringLength(1000)]
    public string? NoticeNo { get; set; }

    [StringLength(1000)]
    public string? NoticeProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? NoticeTypeCode { get; set; }

    [StringLength(1000)]
    public string? NotificationDate { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? OriginalNoticeNo { get; set; }

    [StringLength(1000)]
    public string? PaymentDeadline { get; set; }

    public DateTime? PaymentNoticeIssuanceMoment { get; set; }

    [StringLength(1000)]
    public string? ReceiptIssuedOn { get; set; }

    [StringLength(1000)]
    public string? ReferenceDate { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? RefundedAmount { get; set; }

    [StringLength(1000)]
    public string? SentYn { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [StringLength(1000)]
    public string? StaggeredNoticeOn { get; set; }

    [StringLength(1000)]
    public string? StaggeredNoticeProcessingCode { get; set; }

    [StringLength(1000)]
    public string? TaxpayerIdentificationNo { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalAmount { get; set; }

    [StringLength(1000)]
    public string? TransmissionTypeCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? UnadjustedLateInterestAmount { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? UseOfRemovalCreditOn { get; set; }

    [StringLength(1000)]
    public string? VehicleOn { get; set; }
}

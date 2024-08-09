namespace Collection.APIs.Dtos;

public class AdjustmentWhereInput
{
    public string? AdjustmentDate { get; set; }

    public string? AdjustmentReasonContent { get; set; }

    public string? AttachedFileId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public double? LatePaymentInterestAmount { get; set; }

    public double? LatePaymentInterestAmountExistingBeforeLatePayment { get; set; }

    public string? NoticeNumber { get; set; }

    public double? NumberOfAdjustments { get; set; }

    public double? NumberOfLatePayments { get; set; }

    public string? OfficeCode { get; set; }

    public double? PreviousTotalNoticeAmount { get; set; }

    public string? RegisteringPersonId { get; set; }

    public string? ServiceCode { get; set; }

    public double? TotalNoticeAmount { get; set; }

    public double? UnadjustedLatePaymentInterestAmount { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

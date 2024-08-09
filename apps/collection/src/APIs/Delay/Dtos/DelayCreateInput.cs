namespace Collection.APIs.Dtos;

public class DelayCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? DeletionFlag { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? LatePaymentDate { get; set; }

    public double? LatePaymentInterestAmount { get; set; }

    public double? LatePaymentInterestAmountExistingBeforeLatePayment { get; set; }

    public string? NoticeNumber { get; set; }

    public string? NotificationDate { get; set; }

    public double? NumberOfTimesOfLatePayments { get; set; }

    public string? OfficeCode { get; set; }

    public string? PaymentDeadline { get; set; }

    public double? PenaltyRate { get; set; }

    public string? PreviousDueDate { get; set; }

    public string? PreviousNotificationDate { get; set; }

    public string? ServiceCode { get; set; }

    public double? TotalNoticeAmount { get; set; }

    public double? TotalPreviousNoticeAmount { get; set; }

    public double? UnadjustedLatePaymentInterestAmount { get; set; }

    public DateTime UpdatedAt { get; set; }
}

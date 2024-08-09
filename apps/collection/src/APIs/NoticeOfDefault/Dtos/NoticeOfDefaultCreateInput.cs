namespace Collection.APIs.Dtos;

public class NoticeOfDefaultCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? DefaultNoticeNumber { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public double? InitialApAmount { get; set; }

    public string? LatePaymentDate { get; set; }

    public double? LatePaymentInterestAmount { get; set; }

    public string? NoticeNumber { get; set; }

    public string? NotificationDate { get; set; }

    public double? NumberOfDefaultNotices { get; set; }

    public double? NumberOfLatePayments { get; set; }

    public string? PaymentDeadline { get; set; }

    public DateTime UpdatedAt { get; set; }
}

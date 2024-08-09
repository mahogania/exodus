namespace Collection.APIs.Dtos;

public class NoticeTypeWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public double? LatePaymentInterestAmountCapRate { get; set; }

    public double? LatePaymentInterestRate { get; set; }

    public string? NoticeTypeCode { get; set; }

    public double? NumberOfDueDays { get; set; }

    public double? NumberOfTimesUsed { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UsedOn { get; set; }
}

namespace Collection.APIs.Dtos;

public class CauseCreateInput
{
    public double? AlignmentOrder { get; set; }

    public double? AmountActuallyPaid { get; set; }

    public double? AmountOfOtherChargeableFees { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? NoticeNo { get; set; }

    public string? OtherChargeableFeesCode { get; set; }

    public string? OtherChargeableFeesTaxCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}

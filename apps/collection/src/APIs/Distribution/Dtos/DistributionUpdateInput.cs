namespace Collection.APIs.Dtos;

public class DistributionUpdateInput
{
    public string? AccountCode { get; set; }

    public double? CollectedAmount { get; set; }

    public string? CollectionNo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DebitOrCreditDesignationCode { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? NoticeNo { get; set; }

    public string? NoticeTypeCode { get; set; }

    public string? NotificationDate { get; set; }

    public string? OfficeCode { get; set; }

    public string? PaymentDate { get; set; }

    public string? ProcessingOn { get; set; }

    public string? ServiceCode { get; set; }

    public string? TaxCode { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

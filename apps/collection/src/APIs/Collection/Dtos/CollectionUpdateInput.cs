namespace Collection.APIs.Dtos;

public class CollectionUpdateInput
{
    public string? AttachmentFileId { get; set; }

    public double? CollectedAmount { get; set; }

    public string? CollectionBankCode { get; set; }

    public string? CollectionNo { get; set; }

    public string? CollectionTypeCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public string? ExpenseCertificateNo { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? ManualRegistrationReasonContent { get; set; }

    public string? NoticeNo { get; set; }

    public string? OfficeCode { get; set; }

    public string? PaymentDate { get; set; }

    public string? RegisteringPersonId { get; set; }

    public string? RegistrationDate { get; set; }

    public string? RegistrationSystemCategoryCode { get; set; }

    public string? ServiceCode { get; set; }

    public string? TaxpayerPhoneNo { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

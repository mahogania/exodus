namespace Collection.APIs.Dtos;

public class Fine
{
    public string? AttachmentId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DeclarantCode { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FinancialManagerName { get; set; }

    public double? FineAmount { get; set; }

    public double? FineAmountInEur { get; set; }

    public double? FineAmountInUsd { get; set; }

    public string? FineCancellationDate { get; set; }

    public string? FineCancellationOfficerId { get; set; }

    public string? FineCancellationReasonContent { get; set; }

    public string? FineCancellationRequestNo { get; set; }

    public string? FineImpositionRequestNo { get; set; }

    public string? FineRegistrationReasonContent { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string Id { get; set; }

    public string? NiuCategoryCode { get; set; }

    public string? NiuCategoryName { get; set; }

    public string? NoticeNo { get; set; }

    public string? NotificationRequiredOn { get; set; }

    public string? OfficeCode { get; set; }

    public string? ReferenceDate { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceNumberTypeCode { get; set; }

    public string? ReferenceNumberTypeName { get; set; }

    public string? RegisteringPersonId { get; set; }

    public string? RegistrationDate { get; set; }

    public string? ServiceCode { get; set; }

    public string? TaxpayerIdentificationNo { get; set; }

    public DateTime UpdatedAt { get; set; }
}

namespace Collection.APIs.Dtos;

public class RefundRequest
{
    public string? AccountCode { get; set; }

    public string? ApprovalId { get; set; }

    public string? AttachedFileId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DeletionFlag { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FinancialOfficerSName { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string Id { get; set; }

    public string? NiuCategoryCode { get; set; }

    public string? OfficeCode { get; set; }

    public string? PersonRequestingId { get; set; }

    public string? ProcessingStatusCode { get; set; }

    public string? ReceiptNumber { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? ReferenceNumberTypeCode { get; set; }

    public string? RefundRequestNumber { get; set; }

    public string? RefundRequestedOn { get; set; }

    public string? RequestDate { get; set; }

    public string? ServiceCode { get; set; }

    public string? TaxpayerIdentificationNumber { get; set; }

    public DateTime UpdatedAt { get; set; }
}

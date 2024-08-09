namespace Collection.APIs.Dtos;

public class OrderCreateInput
{
    public string? AccountCode { get; set; }

    public string? ApprovalId { get; set; }

    public string? AttachmentId { get; set; }

    public string? BankAccountNo { get; set; }

    public string? CollectionNo { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DeletionOn { get; set; }

    public string? DraftingServiceCode { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FinancialOfficerName { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? ImputationAccountCode { get; set; }

    public string? NiuCategoryCode { get; set; }

    public string? OfficeCode { get; set; }

    public string? OperationPeriodYearMonth { get; set; }

    public string? OperationSourceCode { get; set; }

    public double? PaidAmount { get; set; }

    public string? PaymentOrderClassificationCode { get; set; }

    public string? PaymentOrderDate { get; set; }

    public string? PaymentOrderNo { get; set; }

    public string? PaymentTypeCode { get; set; }

    public string? ReceiptDate { get; set; }

    public string? ReceiptNo { get; set; }

    public string? ReferenceDate { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceNumberTypeCode { get; set; }

    public string? RegisteringPersonId { get; set; }

    public string? ServiceCode { get; set; }

    public string? TaxpayerIdentificationNo { get; set; }

    public DateTime UpdatedAt { get; set; }
}

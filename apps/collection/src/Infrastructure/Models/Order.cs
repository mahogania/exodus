using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Orders")]
public class OrderDbModel
{
    [StringLength(1000)] public string? AccountCode { get; set; }

    [StringLength(1000)] public string? ApprovalId { get; set; }

    [StringLength(1000)] public string? AttachmentId { get; set; }

    [StringLength(1000)] public string? BankAccountNo { get; set; }

    [StringLength(1000)] public string? CollectionNo { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    [StringLength(1000)] public string? DraftingServiceCode { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    [StringLength(1000)] public string? FinancialOfficerName { get; set; }

    [StringLength(1000)] public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? ImputationAccountCode { get; set; }

    [StringLength(1000)] public string? NiuCategoryCode { get; set; }

    [StringLength(1000)] public string? OfficeCode { get; set; }

    [StringLength(1000)] public string? OperationPeriodYearMonth { get; set; }

    [StringLength(1000)] public string? OperationSourceCode { get; set; }

    [Range(-999999999, 999999999)] public double? PaidAmount { get; set; }

    [StringLength(1000)] public string? PaymentOrderClassificationCode { get; set; }

    [StringLength(1000)] public string? PaymentOrderDate { get; set; }

    [StringLength(1000)] public string? PaymentOrderNo { get; set; }

    [StringLength(1000)] public string? PaymentTypeCode { get; set; }

    [StringLength(1000)] public string? ReceiptDate { get; set; }

    [StringLength(1000)] public string? ReceiptNo { get; set; }

    [StringLength(1000)] public string? ReferenceDate { get; set; }

    [StringLength(1000)] public string? ReferenceNo { get; set; }

    [StringLength(1000)] public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)] public string? RegisteringPersonId { get; set; }

    [StringLength(1000)] public string? ServiceCode { get; set; }

    [StringLength(1000)] public string? TaxpayerIdentificationNo { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

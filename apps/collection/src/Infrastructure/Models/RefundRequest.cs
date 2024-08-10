using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("RefundRequests")]
public class RefundRequestDbModel
{
    [StringLength(1000)] public string? AccountCode { get; set; }

    [StringLength(1000)] public string? ApprovalId { get; set; }

    [StringLength(1000)] public string? AttachedFileId { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionFlag { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    [StringLength(1000)] public string? FinancialOfficerSName { get; set; }

    [StringLength(1000)] public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? NiuCategoryCode { get; set; }

    [StringLength(1000)] public string? OfficeCode { get; set; }

    [StringLength(1000)] public string? PersonRequestingId { get; set; }

    [StringLength(1000)] public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)] public string? ReceiptNumber { get; set; }

    [StringLength(1000)] public string? ReferenceNumber { get; set; }

    [StringLength(1000)] public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)] public string? RefundRequestNumber { get; set; }

    [StringLength(1000)] public string? RefundRequestedOn { get; set; }

    [StringLength(1000)] public string? RequestDate { get; set; }

    [StringLength(1000)] public string? ServiceCode { get; set; }

    [StringLength(1000)] public string? TaxpayerIdentificationNumber { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

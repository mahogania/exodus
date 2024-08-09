using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Fines")]
public class FineDbModel
{
    [StringLength(1000)]
    public string? AttachmentId { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeclarantCode { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FinancialManagerName { get; set; }

    [Range(-999999999, 999999999)]
    public double? FineAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? FineAmountInEur { get; set; }

    [Range(-999999999, 999999999)]
    public double? FineAmountInUsd { get; set; }

    [StringLength(1000)]
    public string? FineCancellationDate { get; set; }

    [StringLength(1000)]
    public string? FineCancellationOfficerId { get; set; }

    [StringLength(1000)]
    public string? FineCancellationReasonContent { get; set; }

    [StringLength(1000)]
    public string? FineCancellationRequestNo { get; set; }

    [StringLength(1000)]
    public string? FineImpositionRequestNo { get; set; }

    [StringLength(1000)]
    public string? FineRegistrationReasonContent { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? NiuCategoryCode { get; set; }

    [StringLength(1000)]
    public string? NiuCategoryName { get; set; }

    [StringLength(1000)]
    public string? NoticeNo { get; set; }

    [StringLength(1000)]
    public string? NotificationRequiredOn { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceDate { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeName { get; set; }

    [StringLength(1000)]
    public string? RegisteringPersonId { get; set; }

    [StringLength(1000)]
    public string? RegistrationDate { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [StringLength(1000)]
    public string? TaxpayerIdentificationNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

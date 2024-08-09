using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("ClaimedFines")]
public class ClaimedFineDbModel
{
    [StringLength(1000)]
    public string? AcceptedByTaxpayerOn { get; set; }

    [StringLength(1000)]
    public string? ApprovalId { get; set; }

    [StringLength(1000)]
    public string? AttachedFileId { get; set; }

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
    public string? FinancialOfficerName { get; set; }

    [Range(-999999999, 999999999)]
    public double? FineAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? FineAmountInEur { get; set; }

    [Range(-999999999, 999999999)]
    public double? FineAmountInUsd { get; set; }

    [StringLength(1000)]
    public string? FineImpositionRequestNumber { get; set; }

    [StringLength(1000)]
    public string? FineRegistrationReasonContent { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? NotificationRequiredOn { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? OpinionRegisteredByTaxpayerOn { get; set; }

    [StringLength(1000)]
    public string? ReferenceDate { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeName { get; set; }

    [StringLength(1000)]
    public string? RequestDate { get; set; }

    [StringLength(1000)]
    public string? RequestingPersonId { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    public DateTime? TaxpayerAcceptanceMoment { get; set; }

    [StringLength(1000)]
    public string? TaxpayerIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? TinCategoryCode { get; set; }

    [StringLength(1000)]
    public string? TinCategoryName { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

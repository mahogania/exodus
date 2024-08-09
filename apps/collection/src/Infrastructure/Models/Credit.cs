using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Credits")]
public class CreditDbModel
{
    [StringLength(1000)]
    public string? AdjustmentDate { get; set; }

    [StringLength(1000)]
    public string? AgencyCode { get; set; }

    [StringLength(1000)]
    public string? AssignedAccountant { get; set; }

    [StringLength(1000)]
    public string? AttachmentId { get; set; }

    [StringLength(1000)]
    public string? AuthorizingOfficerDesignation { get; set; }

    [StringLength(1000)]
    public string? AuthorizingOfficerQuality { get; set; }

    [StringLength(1000)]
    public string? BankAccountNo { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsNote { get; set; }

    [StringLength(1000)]
    public string? DeclarantCode { get; set; }

    [StringLength(1000)]
    public string? DeclarationNo { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Range(-999999999, 999999999)]
    public double? GuaranteeAmount { get; set; }

    [StringLength(1000)]
    public string? GuaranteeClosedOn { get; set; }

    [StringLength(1000)]
    public string? GuaranteeClosureDate { get; set; }

    [StringLength(1000)]
    public string? GuaranteeIssuanceNo { get; set; }

    [StringLength(1000)]
    public string? GuaranteeNo { get; set; }

    [StringLength(1000)]
    public string? GuaranteeTypeCode { get; set; }

    [StringLength(1000)]
    public string? GuaranteeValidityStatusCode { get; set; }

    [StringLength(1000)]
    public string? GuarantorOrganizationCode { get; set; }

    [StringLength(1000)]
    public string? GuarantorOrganizationName { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? RegisteringPersonId { get; set; }

    [StringLength(1000)]
    public string? RegistrationDate { get; set; }

    [StringLength(1000)]
    public string? RejectionReason { get; set; }

    [StringLength(1000)]
    public string? RejectionReasonContent { get; set; }

    [StringLength(1000)]
    public string? RequestDate { get; set; }

    [StringLength(1000)]
    public string? RequestNo { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [StringLength(1000)]
    public string? TaxIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? UnknownField { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? ValidityEndDate { get; set; }

    [StringLength(1000)]
    public string? ValidityStartDate { get; set; }
}

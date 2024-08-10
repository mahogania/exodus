using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Securities")]
public class SecurityDbModel
{
    [StringLength(1000)] public string? AdjustmentDate { get; set; }

    [StringLength(1000)] public string? AssignedAccountant { get; set; }

    [StringLength(1000)] public string? AuthorizingOfficerSCapacity { get; set; }

    [StringLength(1000)] public string? AuthorizingOfficerSDesignation { get; set; }

    [StringLength(1000)] public string? BankAccountNumber { get; set; }

    [StringLength(1000)] public string? BankBranchCode { get; set; }

    [StringLength(1000)] public string? BankCode { get; set; }

    [StringLength(1000)] public string? CompanyAddress { get; set; }

    [StringLength(1000)] public string? CompanyName { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? CustomsNote { get; set; }

    [StringLength(1000)] public string? DeclarationDate { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [StringLength(1000)] public string? GuarantorOrganizationCode { get; set; }

    [StringLength(1000)] public string? GuarantorOrganizationName { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? OfficeCode { get; set; }

    [StringLength(1000)] public string? PrincipalObligor { get; set; }

    [StringLength(1000)] public string? RegisteringPersonId { get; set; }

    [StringLength(1000)] public string? RejectYesNo { get; set; }

    [StringLength(1000)] public string? RejectionReason { get; set; }

    [StringLength(1000)] public string? RepresentativeSLastName { get; set; }

    [StringLength(1000)] public string? RequestDate { get; set; }

    [StringLength(1000)] public string? RequestNumber { get; set; }

    [Range(-999999999, 999999999)] public double? SecurityAmount { get; set; }

    [StringLength(1000)] public string? SecurityClosureDate { get; set; }

    [StringLength(1000)] public string? SecurityIssuanceNumber { get; set; }

    [StringLength(1000)] public string? SecurityReleaseCertificateIssuanceDate { get; set; }

    [StringLength(1000)] public string? SecurityTypeCode { get; set; }

    [StringLength(1000)] public string? SecurityValidityStatusCode { get; set; }

    [StringLength(1000)] public string? ServiceCode { get; set; }

    [StringLength(1000)] public string? SuspensionReason { get; set; }

    [StringLength(1000)] public string? TaxIdentificationNumber { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }

    [StringLength(1000)] public string? ValidityEndDate { get; set; }

    [StringLength(1000)] public string? ValidityStartDate { get; set; }
}

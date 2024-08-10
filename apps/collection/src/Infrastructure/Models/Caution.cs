using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Cautions")]
public class CautionDbModel
{
    [StringLength(1000)] public string? AdjustmentDate { get; set; }

    [StringLength(1000)] public string? AssigningAccountant { get; set; }

    [StringLength(1000)] public string? AttachedFileId { get; set; }

    [StringLength(1000)] public string? BankAccountNumber { get; set; }

    [StringLength(1000)] public string? BankAgencyCode { get; set; }

    [StringLength(1000)] public string? BankCode { get; set; }

    [Range(-999999999, 999999999)] public double? CautionAmount { get; set; }

    [StringLength(1000)] public string? CautionClosureDate { get; set; }

    [StringLength(1000)] public string? CautionDeliveryNumber { get; set; }

    [StringLength(1000)] public string? CautionNumber { get; set; }

    [StringLength(1000)] public string? CautionTypeCode { get; set; }

    [StringLength(1000)] public string? CautionValidityEndDate { get; set; }

    [StringLength(1000)] public string? CautionValidityStartDate { get; set; }

    [StringLength(1000)] public string? CautionValidityStatusCode { get; set; }

    [StringLength(1000)] public string? CompanyAddress { get; set; }

    [StringLength(1000)] public string? CompanyName { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? CustomsNote { get; set; }

    [StringLength(1000)] public string? DateOfCautionReleaseCertificateDelivery { get; set; }

    [StringLength(1000)] public string? DeclarantCode { get; set; }

    [StringLength(1000)] public string? DeclarationDate { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [StringLength(1000)] public string? GuarantorOrganizationCode { get; set; }

    [StringLength(1000)] public string? GuarantorOrganizationName { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? OfficeCode { get; set; }

    [StringLength(1000)] public string? OrderGiverDesignation { get; set; }

    [StringLength(1000)] public string? OrderGiverQuality { get; set; }

    [StringLength(1000)] public string? PersonInChargeOfCautionReleaseCertificateDeliveryCode { get; set; }

    [StringLength(1000)] public string? PersonRegisteringId { get; set; }

    [StringLength(1000)] public string? PrincipalObligated { get; set; }

    [StringLength(1000)] public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)] public string? RejectYesNo { get; set; }

    [StringLength(1000)] public string? RejectionReason { get; set; }

    [StringLength(1000)] public string? RepresentativeLastName { get; set; }

    [StringLength(1000)] public string? RequestDate { get; set; }

    [StringLength(1000)] public string? RequestNumber { get; set; }

    [StringLength(1000)] public string? ServiceCode { get; set; }

    [StringLength(1000)] public string? SuspensionReason { get; set; }

    [StringLength(1000)] public string? TaxIdentificationNumber { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

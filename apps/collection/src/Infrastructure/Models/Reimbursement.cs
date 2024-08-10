using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Reimbursements")]
public class ReimbursementDbModel
{
    [StringLength(1000)] public string? AttachmentFileId { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    [StringLength(1000)] public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? OfficeCode { get; set; }

    [StringLength(1000)] public string? ReceiverSOpinion { get; set; }

    [StringLength(1000)] public string? RegistrationPersonIdentifier { get; set; }

    [Range(-999999999, 999999999)] public double? ReimbursedAmount { get; set; }

    [StringLength(1000)] public string? ReimbursementDate { get; set; }

    [StringLength(1000)] public string? ReimbursementDecisionType { get; set; }

    [StringLength(1000)] public string? ReimbursementNo { get; set; }

    [StringLength(1000)] public string? ReimbursementReasonContent { get; set; }

    [StringLength(1000)] public string? ReimbursementRequestNo { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

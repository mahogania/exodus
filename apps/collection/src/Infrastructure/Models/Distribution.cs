using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Distributions")]
public class DistributionDbModel
{
    [StringLength(1000)]
    public string? AccountCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? CollectedAmount { get; set; }

    [StringLength(1000)]
    public string? CollectionNo { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DebitOrCreditDesignationCode { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? NoticeNo { get; set; }

    [StringLength(1000)]
    public string? NoticeTypeCode { get; set; }

    [StringLength(1000)]
    public string? NotificationDate { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? PaymentDate { get; set; }

    [StringLength(1000)]
    public string? ProcessingOn { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [StringLength(1000)]
    public string? TaxCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

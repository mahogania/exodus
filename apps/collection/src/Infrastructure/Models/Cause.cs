using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Causes")]
public class CauseDbModel
{
    [Range(-999999999, 999999999)]
    public double? AlignmentOrder { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountActuallyPaid { get; set; }

    [Range(-999999999, 999999999)]
    public double? AmountOfOtherChargeableFees { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

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
    public string? OtherChargeableFeesCode { get; set; }

    [StringLength(1000)]
    public string? OtherChargeableFeesTaxCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

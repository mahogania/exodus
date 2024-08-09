using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Deposits")]
public class DepositDbModel
{
    [Range(-999999999, 999999999)]
    public double? AmountUsed { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? DepositCeiling { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfTimesUsed { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? RequestNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    public DateTime? UsageMoment { get; set; }
}

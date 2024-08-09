using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("FineCauses")]
public class FineCauseDbModel
{
    [Range(-999999999, 999999999)]
    public double? AlignmentOrder { get; set; }

    [Range(-999999999, 999999999)]
    public double? CappedAmount { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionFlag { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [Range(-999999999, 999999999)]
    public double? FineAmount { get; set; }

    [StringLength(1000)]
    public string? FineTaxCode { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InfractionCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? MinimumAmount { get; set; }

    [StringLength(1000)]
    public string? NoticeNumber { get; set; }

    [StringLength(1000)]
    public string? OperationTypeCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

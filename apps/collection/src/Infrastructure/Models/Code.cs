using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Codes")]
public class CodeDbModel
{
    [Range(-999999999, 999999999)] public double? CappedAmount { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    [StringLength(1000)] public string? FineRelatedTaxCode { get; set; }

    [StringLength(1000)] public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Range(-999999999, 999999999)] public double? FloorAmount { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? InfractionCode { get; set; }

    [StringLength(1000)] public string? InfractionCodeDescription { get; set; }

    [StringLength(1000)] public string? InfractionCodeDetails { get; set; }

    [StringLength(1000)] public string? InfractionCodeLabel { get; set; }

    [StringLength(1000)] public string? OperationTypeCode { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }

    [StringLength(1000)] public string? UsedOn { get; set; }
}

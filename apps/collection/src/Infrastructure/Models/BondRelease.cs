using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("BondReleases")]
public class BondReleaseDbModel
{
    [Range(-999999999, 999999999)] public double? AmountReturnedAfterRelease { get; set; }

    public DateTime? BondReleaseMoment { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierId { get; set; }

    [StringLength(1000)] public string? FinalReleaseYn { get; set; }

    [StringLength(1000)] public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key] [Required] public string Id { get; set; }

    [Range(-999999999, 999999999)] public double? NumberOfBondReleases { get; set; }

    [StringLength(1000)] public string? ReferenceNo { get; set; }

    [StringLength(1000)] public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)] public string? ReferenceNumberUsed { get; set; }

    [StringLength(1000)] public string? RequestNo { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

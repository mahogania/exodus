using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("InformationForDeterminingOrigins")]
public class InformationForDeterminingOriginDbModel
{
    [Range(-999999999, 999999999)]
    public double? Amount { get; set; }

    [StringLength(1000)]
    public string? CountryOfOriginCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderSId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? NameOfMaterialsUsed { get; set; }

    [Range(-999999999, 999999999)]
    public double? OriginDeterminationSeriesNumber { get; set; }

    [StringLength(1000)]
    public string? RcoRequestNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? ShCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? Weight { get; set; }
}

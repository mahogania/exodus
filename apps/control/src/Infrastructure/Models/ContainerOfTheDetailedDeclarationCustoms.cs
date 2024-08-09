using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ContainerOfTheDetailedDeclarationCustoms")]
public class ContainerOfTheDetailedDeclarationCustomsDbModel
{
    [StringLength(1000)]
    public string? ContainerNumber { get; set; }

    [StringLength(1000)]
    public string? ContainerPackingStateCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? ContainerSequenceNumber { get; set; }

    [StringLength(1000)]
    public string? ContainerTypeCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [StringLength(1000)]
    public string? GoodsVerified { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? SealNumber_1 { get; set; }

    [StringLength(1000)]
    public string? SealNumber_2 { get; set; }

    [StringLength(1000)]
    public string? SealNumber_3 { get; set; }

    [StringLength(1000)]
    public string? Sealer_1 { get; set; }

    [StringLength(1000)]
    public string? Sealer_2 { get; set; }

    [StringLength(1000)]
    public string? Sealer_3 { get; set; }

    [StringLength(1000)]
    public string? SealingPersonCode { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

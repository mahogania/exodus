using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("DetailsOfGoodsForPassivePerfections")]
public class DetailsOfGoodsForPassivePerfectionDbModel
{
    [StringLength(1000)]
    public string? BrandName { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeclaredGoodsNames { get; set; }

    [StringLength(1000)]
    public string? DocumentCode { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Range(-999999999, 999999999)]
    public double? GoodsValue { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ImportExportTypeCode { get; set; }

    [StringLength(1000)]
    public string? NatureOfGoodsCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? SequenceNumber { get; set; }

    [StringLength(1000)]
    public string? ShCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? StorageLocation { get; set; }

    [StringLength(1000)]
    public string? StorageLocationUnitCode { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TechnicalName { get; set; }

    [StringLength(1000)]
    public string? TransactionValueCurrencyCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

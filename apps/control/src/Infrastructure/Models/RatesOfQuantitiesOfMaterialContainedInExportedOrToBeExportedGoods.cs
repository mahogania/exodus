using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoods")]
public class RatesOfQuantitiesOfMaterialContainedInExportedOrToBeExportedGoodsDbModel
{
    [Required] public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [StringLength(1000)] public string? FirstRegistrantSId { get; set; }

    [Key] [Required] public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? RatesOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheNationalMarket { get; set; }

    [Range(-999999999, 999999999)] public double? RatesOfQuantitiesOfImportedMaterials { get; set; }

    [Range(-999999999, 999999999)] public double? RatesOfQuantitiesOfImportedPackaging { get; set; }

    [Range(-999999999, 999999999)] public double? RatesOfQuantitiesOfNationalOriginMaterials { get; set; }

    [Range(-999999999, 999999999)] public double? RectificationFrequency { get; set; }

    [StringLength(1000)] public string? RegimeRequestNumber { get; set; }

    [Range(-999999999, 999999999)] public double? SequenceNumber { get; set; }

    [StringLength(1000)] public string? SuppressionOn { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

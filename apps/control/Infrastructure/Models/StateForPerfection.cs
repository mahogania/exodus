using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("StateForPerfections")]
public class StateForPerfectionDbModel
{
    [StringLength(1000)] public string? AddressOfTheDomiciliaryBank { get; set; }

    [StringLength(1000)] public string? CorporateNameOfTheDomiciliaryBank { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? CustomsOfficeAtExportation { get; set; }

    [StringLength(1000)] public string? CustomsOfficeAtImportation { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [StringLength(1000)] public string? FinancingModeOfTheOperation { get; set; }

    [StringLength(1000)] public string? FirstRegistrantSId { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? NatureOfTheOperation { get; set; }

    [Range(-999999999, 999999999)] public double? RateOfLosses { get; set; }

    [Range(-999999999, 999999999)] public double? RateOfNonRecoverableWaste { get; set; }

    [Range(-999999999, 999999999)] public double? RateOfQuantitiesOfExportedMaterials { get; set; }

    [Range(-999999999, 999999999)] public double? RateOfQuantitiesOfExportedPackaging { get; set; }

    [Range(-999999999, 999999999)]
    public double? RateOfQuantitiesOfForeignOriginMaterialsAcquiredOnTheForeignMarket { get; set; }

    [Range(-999999999, 999999999)] public double? RateOfRecoverableWaste { get; set; }

    [Range(-999999999, 999999999)] public double? RateOfWasteOnFinishedProducts { get; set; }

    [StringLength(1000)] public string? RecipientSAddress { get; set; }

    [StringLength(1000)] public string? RecipientSCorporateName { get; set; }

    [StringLength(1000)] public string? RecipientSName { get; set; }

    [Range(-999999999, 999999999)] public double? RectificationFrequency { get; set; }

    [StringLength(1000)] public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)] public string? RequestedEndDate { get; set; }

    [StringLength(1000)] public string? RequestedStartDate { get; set; }

    [StringLength(1000)] public string? SuppressionOn { get; set; }

    [Range(-999999999, 999999999)] public double? TotalAmountForeseenForTransformationRepair { get; set; }

    [StringLength(1000)] public string? TypeOfActivePerfectionSolicited { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

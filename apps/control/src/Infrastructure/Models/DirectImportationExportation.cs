using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("DirectImportationExportations")]
public class DirectImportationExportationDbModel
{
    [StringLength(1000)]
    public string? CargoStatus { get; set; }

    [StringLength(1000)]
    public string? CodeOfTheReimportationReexportationOffice { get; set; }

    [StringLength(1000)]
    public string? ContentsOfTheClearanceObjective { get; set; }

    [StringLength(1000)]
    public string? ContractReferenceCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? DocumentCode { get; set; }

    [StringLength(1000)]
    public string? EndDateOfImportationExportation { get; set; }

    [StringLength(1000)]
    public string? EndDateOfTheClearancePeriod { get; set; }

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
    public string? ImportationExportationTypeCode { get; set; }

    [StringLength(1000)]
    public string? RealizationName { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)]
    public string? ReservedSuites { get; set; }

    [StringLength(1000)]
    public string? RightsAndTaxes { get; set; }

    [StringLength(1000)]
    public string? StartDateOfImportationExportation { get; set; }

    [StringLength(1000)]
    public string? StartDateOfTheClearancePeriod { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

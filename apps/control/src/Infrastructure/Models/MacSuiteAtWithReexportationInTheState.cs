using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("MacSuiteAtWithReexportationInTheStates")]
public class MacSuiteAtWithReexportationInTheStateDbModel
{
    [StringLength(1000)]
    public string? ApcCode { get; set; }

    [StringLength(1000)]
    public string? ApcLabel { get; set; }

    [StringLength(1000)]
    public string? AtDeclarationDate { get; set; }

    [StringLength(1000)]
    public string? AtDeclarationNumber { get; set; }

    [StringLength(1000)]
    public string? BusinessRegisterNumber { get; set; }

    [StringLength(1000)]
    public string? ContentOfTheRequestReason { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsClearanceOfficeForMac { get; set; }

    [StringLength(1000)]
    public string? CustomsDeclarationOffice { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DueDate { get; set; }

    [StringLength(1000)]
    public string? EpcCode { get; set; }

    [StringLength(1000)]
    public string? EpcLabel { get; set; }

    [StringLength(1000)]
    public string? ExecutionPlaces { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Importer { get; set; }

    [StringLength(1000)]
    public string? Nif { get; set; }

    [StringLength(1000)]
    public string? NifStatus { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfArticles { get; set; }

    [StringLength(1000)]
    public string? RcStatus { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

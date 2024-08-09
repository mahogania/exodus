using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("FinalExportFollowedByReimportationInTheStates")]
public class FinalExportFollowedByReimportationInTheStateDbModel
{
    [StringLength(1000)]
    public string? ApcCode { get; set; }

    [StringLength(1000)]
    public string? ContentOfTheRequestReason { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsClearanceOfficeForFinalExportFollowedByEt { get; set; }

    [StringLength(1000)]
    public string? CustomsDeclarationOffice { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DateOfEtDeclaration { get; set; }

    [StringLength(1000)]
    public string? EpcCode { get; set; }

    [StringLength(1000)]
    public string? EtDeclarationNumber { get; set; }

    [StringLength(1000)]
    public string? ExecutionPlaces { get; set; }

    [StringLength(1000)]
    public string? ExpiryDate { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? LabelApc { get; set; }

    [StringLength(1000)]
    public string? LabelEpc { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfArticles { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

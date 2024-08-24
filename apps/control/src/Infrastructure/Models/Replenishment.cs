using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("Replenishments")]
public class ReplenishmentDbModel
{
    [StringLength(1000)]
    public string? ApcCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsClearanceOfficeForReplenishmentInDutyFree { get; set; }

    [StringLength(1000)]
    public string? CustomsClearanceOfficeOfDeclaration { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DateOfDau { get; set; }

    [StringLength(1000)]
    public string? DeclarationStatus { get; set; }

    [StringLength(1000)]
    public string? EpcCode { get; set; }

    [StringLength(1000)]
    public string? EpcLabel { get; set; }

    [StringLength(1000)]
    public string? ExportDeclarationNumber { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)]
    public string? RequestTypeCode { get; set; }

    [StringLength(1000)]
    public string? RequestedEndDate { get; set; }

    [StringLength(1000)]
    public string? RequestedStartDate { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

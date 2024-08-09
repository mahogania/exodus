using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("AtAndStandardExchanges")]
public class AtAndStandardExchangeDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsClearanceOfficeForAtEt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DateOfTheImportationDeclaration { get; set; }

    [StringLength(1000)]
    public string? DeclarationNumber { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ImportationDeclarationCode { get; set; }

    [StringLength(1000)]
    public string? ReasonForTheRequest { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)]
    public string? RequestStatus { get; set; }

    [StringLength(1000)]
    public string? RequestedEndDate { get; set; }

    [StringLength(1000)]
    public string? RequestedStartDate { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? WarrantyEndDate { get; set; }

    [StringLength(1000)]
    public string? WarrantyFrame { get; set; }
}

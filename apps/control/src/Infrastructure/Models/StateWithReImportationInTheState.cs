using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("StateWithReImportationInTheStates")]
public class StateWithReImportationInTheStateDbModel
{
    [StringLength(1000)]
    public string? Address { get; set; }

    [StringLength(1000)]
    public string? ContractObject { get; set; }

    [StringLength(1000)]
    public string? ContractReference { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsOfficeForReImportationIndicative { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? ExportingCountryCode { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [StringLength(1000)]
    public string? ForeignRecipient { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)]
    public string? RequestedEndDateOfTemporaryExport { get; set; }

    [StringLength(1000)]
    public string? RequestedStartDateOfTemporaryExport { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? UnknownFieldOne { get; set; }

    [StringLength(1000)]
    public string? UnknownFieldTwo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

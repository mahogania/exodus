using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("DetailedDeclarationOperatorCustoms")]
public class DetailedDeclarationOperatorCustomsDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeclarantSAddress { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? ExporterSAddress { get; set; }

    [StringLength(1000)]
    public string? ExporterSEmail { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ImporterSAddress { get; set; }

    [StringLength(1000)]
    public string? NameOfTheDeclarantSCompany { get; set; }

    [StringLength(1000)]
    public string? NameOfTheExporterSCompany { get; set; }

    [StringLength(1000)]
    public string? NameOfTheImporterSCompany { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? TaxpayerPhoneNumber { get; set; }

    [StringLength(1000)]
    public string? TaxpayerSAddress { get; set; }

    [StringLength(1000)]
    public string? TaxpayerSCompanyName { get; set; }

    [StringLength(1000)]
    public string? TaxpayerSEmail { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

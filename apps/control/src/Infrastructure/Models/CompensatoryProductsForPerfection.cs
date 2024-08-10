using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("CompensatoryProductsForPerfections")]
public class CompensatoryProductsForPerfectionDbModel
{
    [StringLength(1000)] public string? CommercialDesignationOfGoods { get; set; }

    [StringLength(1000)] public string? CountryOfExportation { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [StringLength(1000)] public string? FirstRecorderSId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key] [Required] public string Id { get; set; }

    [Range(-999999999, 999999999)] public double? IntegrationRate { get; set; }

    [StringLength(1000)] public string? Origin { get; set; }

    [Range(-999999999, 999999999)] public double? Quantity { get; set; }

    [StringLength(1000)] public string? RealExporterOfGoods { get; set; }

    [Range(-999999999, 999999999)] public double? RectificationFrequency { get; set; }

    [StringLength(1000)] public string? RegimeRequestNumber { get; set; }

    [Range(-999999999, 999999999)] public double? SequenceNumber { get; set; }

    [StringLength(1000)] public string? SptNumber { get; set; }

    [StringLength(1000)] public string? TechnicalDesignationOfGoods { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

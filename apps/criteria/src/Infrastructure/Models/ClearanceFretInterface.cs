using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("ClearanceFretInterfaces")]
public class ClearanceFretInterfaceDbModel
{
    [Range(-999999999, 999999999)]
    public double? AuthorizedGrossWeight { get; set; }

    [StringLength(1000)]
    public string? AuthorizedNetWeightUnitCodeProcessingOn { get; set; }

    [StringLength(1000)]
    public string? AuthorizedPackageUnitCode { get; set; }

    [Range(-999999999, 999999999)]
    public int? AuthorizedPackagingNumber { get; set; }

    public List<ClearanceFretContainerDbModel>? ClearanceFretContainer { get; set; } =
        new List<ClearanceFretContainerDbModel>();

    [StringLength(1000)]
    public string? ContainerizedCargoStorageLocationCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Crn { get; set; }

    [StringLength(1000)]
    public string? DeclarantCode { get; set; }

    [StringLength(1000)]
    public string? DeclarationTypeCode { get; set; }

    [StringLength(1000)]
    public string? DetailedDeclarationNumber { get; set; }

    [StringLength(1000)]
    public string? EpcCode { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ProcessingContent { get; set; }

    [StringLength(1000)]
    public string? ProcessingResultCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    public DateTime? ValidationDate { get; set; }
}

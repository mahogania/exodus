using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("RawMaterialOfTheDetailedDeclarationCustoms")]
public class RawMaterialOfTheDetailedDeclarationCustomsDbModel
{
    [StringLength(1000)] public string? ArticleNumber { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [StringLength(1000)] public string? FirstRegistrantSId { get; set; }

    [Key] [Required] public string Id { get; set; }

    [Range(-999999999, 999999999)] public double? MaterialRawSequenceNumber { get; set; }

    [Range(-999999999, 999999999)] public double? NetWeight { get; set; }

    [StringLength(1000)] public string? PartialClearanceTypeCode { get; set; }

    [StringLength(1000)] public string? PreviousArticleNumber { get; set; }

    [StringLength(1000)] public string? PreviousDetailedDeclarationNumber { get; set; }

    [StringLength(1000)] public string? PreviousShCode { get; set; }

    [StringLength(1000)] public string? PreviousSpecificCodeOfTheMerchandiseClassification { get; set; }

    [Range(-999999999, 999999999)] public double? Quantity { get; set; }

    [StringLength(1000)] public string? QuantityUnitCode { get; set; }

    [Range(-999999999, 999999999)] public double? RectificationFrequency { get; set; }

    [StringLength(1000)] public string? ReferenceNumber { get; set; }

    [StringLength(1000)] public string? SuppressionOn { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("GoodsSubjectToAuthorizations")]
public class GoodsSubjectToAuthorizationDbModel
{
    [StringLength(1000)] public string? CommercialDesignationOfMaterials { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? CurrencyCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [StringLength(1000)] public string? FirstRecorderSId { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? Identification { get; set; }

    [StringLength(1000)] public string? NumberOfTheArticleConcerned { get; set; }

    [StringLength(1000)] public string? Origin { get; set; }

    [Range(-999999999, 999999999)] public double? Quantity { get; set; }

    [Range(-999999999, 999999999)] public double? RectificationFrequency { get; set; }

    [StringLength(1000)] public string? ReferenceSOfTheModelSOfTheArticleConcerned { get; set; }

    [StringLength(1000)] public string? RegimeRequestNumber { get; set; }

    [Range(-999999999, 999999999)] public double? SequenceNumber { get; set; }

    [StringLength(1000)] public string? SptNumber { get; set; }

    [StringLength(1000)] public string? TechnicalDesignationOfMaterials { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)] public double? Value { get; set; }
}

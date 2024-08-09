using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("InfosGoodsToBeReprovisioneds")]
public class InfosGoodsToBeReprovisionedDbModel
{
    [StringLength(1000)]
    public string? CommercialDesignationOfGoods { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? NatureOfTheGoods { get; set; }

    [StringLength(1000)]
    public string? NumberOfTheConcernedArticle { get; set; }

    [StringLength(1000)]
    public string? Origin { get; set; }

    [StringLength(1000)]
    public string? ProposedMeansForTheQuantitativeAndTechnicalControlOfEquivalence { get; set; }

    [StringLength(1000)]
    public string? Provenance { get; set; }

    [Range(-999999999, 999999999)]
    public double? QuantityIncludingNonRecoverableWaste { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? ReferencesOfTheConcernedArticleModelS { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? SequenceNumber { get; set; }

    [StringLength(1000)]
    public string? SptNumber { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TechnicalCharacteristics { get; set; }

    [StringLength(1000)]
    public string? TechnicalDesignationOfGoods { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

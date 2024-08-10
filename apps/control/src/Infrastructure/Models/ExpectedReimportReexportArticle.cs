using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ExpectedReimportReexportArticles")]
public class ExpectedReimportReexportArticleDbModel
{
    [Range(-999999999, 999999999)] public double? ArticleGrossWeight { get; set; }

    [StringLength(1000)] public string? ArticleName { get; set; }

    [Range(-999999999, 999999999)] public double? ArticleNetWeight { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)] public string? ExpectedArticleNumber { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? IdDuPremierEnregistrant { get; set; }

    [StringLength(1000)] public string? Key { get; set; }

    [StringLength(1000)] public string? OriginCountryCode { get; set; }

    [Range(-999999999, 999999999)] public double? Quantity { get; set; }

    [StringLength(1000)] public string? QuantityUnitCode { get; set; }

    [Range(-999999999, 999999999)] public double? RectificationFrequency { get; set; }

    [StringLength(1000)] public string? ReferenceNumber { get; set; }

    [StringLength(1000)] public string? ShCode { get; set; }

    [StringLength(1000)] public string? SpecificGoodsClassificationCode { get; set; }

    [StringLength(1000)] public string? SuppressionOn { get; set; }

    [StringLength(1000)] public string? TransactionArticleName { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

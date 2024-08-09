using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("GoodsImportedForPerfectings")]
public class GoodsImportedForPerfectingDbModel
{
    [StringLength(1000)]
    public string? AddressOfTheExporterOwnerOfGoodsToTransformRepair { get; set; }

    [Range(-999999999, 999999999)]
    public double? AnotherUnknownField { get; set; }

    [StringLength(1000)]
    public string? CommercialDesignationOfGoods { get; set; }

    [StringLength(1000)]
    public string? CommercialDesignationOfGoodsToCompensate { get; set; }

    [Range(-999999999, 999999999)]
    public double? CompensationOfAtAccounts { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CurrencyCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? LegalStatusOfImportedGoods { get; set; }

    [StringLength(1000)]
    public string? NameAndTradeNameOfTheExporterOwnerOfGoodsToTransformRepair { get; set; }

    [StringLength(1000)]
    public string? Origin { get; set; }

    [Range(-999999999, 999999999)]
    public double? Quantity { get; set; }

    [Range(-999999999, 999999999)]
    public double? QuantityOfGoodsToCompensate { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? SequenceNumber { get; set; }

    [StringLength(1000)]
    public string? ShorterOrigin { get; set; }

    [StringLength(1000)]
    public string? SptNumber { get; set; }

    [StringLength(1000)]
    public string? TechnicalDesignationOfGoods { get; set; }

    [StringLength(1000)]
    public string? TechnicalDesignationOfGoodsToCompensate { get; set; }

    [Range(-999999999, 999999999)]
    public double? UnknownField { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? ValueInCurrency { get; set; }
}

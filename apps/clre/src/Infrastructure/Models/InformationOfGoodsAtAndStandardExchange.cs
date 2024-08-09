using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("InformationOfGoodsAtAndStandardExchanges")]
public class InformationOfGoodsAtAndStandardExchangeDbModel
{
    [StringLength(1000)]
    public string? AddressOfTheSupplierRecipientOfTheGoods { get; set; }

    [StringLength(1000)]
    public string? CommercialDesignationOfMaterials { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CurrencyCode { get; set; }

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
    public string? Identification { get; set; }

    [StringLength(1000)]
    public string? NameAndBusinessNameOfTheSupplierRecipientOfTheGoods { get; set; }

    [StringLength(1000)]
    public string? Origin { get; set; }

    [StringLength(1000)]
    public string? ProvenanceDestination { get; set; }

    [Range(-999999999, 999999999)]
    public double? Quantity { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? SequenceNumber { get; set; }

    [StringLength(1000)]
    public string? SptNumber { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TechnicalDesignationOfMaterials { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? Value { get; set; }
}

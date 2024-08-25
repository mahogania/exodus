using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ImportedGoodsInformations")]
public class ImportedGoodsInformationDbModel
{
    [Range(-999999999, 999999999)] public double? AmountOfPaidDutiesAndTaxes { get; set; }

    [StringLength(1000)] public string? ApcCode { get; set; }

    [StringLength(1000)] public string? ApcLabel { get; set; }

    [StringLength(1000)] public string? CommercialDesignationOfGoods { get; set; }

    [StringLength(1000)] public string? CountryOfOrigin { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? CurrencyCode { get; set; }

    [StringLength(1000)] public string? CustomsDeclarationCodeOfTheImportation { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)] public string? DateOfThePaymentOfDutiesAndTaxesReceipt { get; set; }

    [StringLength(1000)] public string? DeclarationStatus { get; set; }

    [StringLength(1000)] public string? EpcCode { get; set; }

    [StringLength(1000)] public string? EpcLabel { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [StringLength(1000)] public string? FirstRegistrantSId { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? ImportationDeclarationNumber { get; set; }

    [StringLength(1000)] public string? NumberOfArticles { get; set; }

    [StringLength(1000)] public string? NumberOfThePaymentOfDutiesAndTaxesReceipt { get; set; }

    [Range(-999999999, 999999999)] public double? Quantity { get; set; }

    [Range(-999999999, 999999999)] public double? RectificationFrequency { get; set; }

    [StringLength(1000)] public string? RegimeRequestNumber { get; set; }

    [Range(-999999999, 999999999)] public double? SequenceNumber { get; set; }

    [StringLength(1000)] public string? SuppressionOn { get; set; }

    [StringLength(1000)] public string? TechnicalDesignationOfGoods { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)] public double? Value { get; set; }
}

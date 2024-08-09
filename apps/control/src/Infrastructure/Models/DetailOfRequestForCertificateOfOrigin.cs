using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("DetailOfRequestForCertificateOfOrigins")]
public class DetailOfRequestForCertificateOfOriginDbModel
{
    [StringLength(1000)]
    public string? BrandName { get; set; }

    [StringLength(1000)]
    public string? CertificateOfOriginRequestNumber { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Crn { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DescriptionOfTheMerchandise { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InvoiceRefInvoice { get; set; }

    [Range(-999999999, 999999999)]
    public double? Quantity { get; set; }

    [Range(-999999999, 999999999)]
    public double? QuantityOfThePackage { get; set; }

    [StringLength(1000)]
    public string? QuantityUnitCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [Range(-999999999, 999999999)]
    public double? SequenceNumber { get; set; }

    [StringLength(1000)]
    public string? ShCode { get; set; }

    [StringLength(1000)]
    public string? Standards { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TradeName { get; set; }

    [StringLength(1000)]
    public string? TypeOfPackagingCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? Weight { get; set; }

    [StringLength(1000)]
    public string? WeightUnit { get; set; }
}

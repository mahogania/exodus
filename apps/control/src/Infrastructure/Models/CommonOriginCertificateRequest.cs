using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("CommonOriginCertificateRequests")]
public class CommonOriginCertificateRequestDbModel
{
    [StringLength(1000)]
    public string? AttachedFileId { get; set; }

    [StringLength(1000)]
    public string? AuthorizedExporterSAuthorizationNumber { get; set; }

    [StringLength(1000)]
    public string? CertificateOfOriginNumber { get; set; }

    [StringLength(1000)]
    public string? CertificateOfOriginRequestNumber { get; set; }

    [StringLength(1000)]
    public string? CodeOfTheGrossWeightUnit { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsOfficeCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeclarantSAddress { get; set; }

    [StringLength(1000)]
    public string? DeclarantSCode { get; set; }

    [StringLength(1000)]
    public string? DeclarantSName { get; set; }

    [StringLength(1000)]
    public string? DepartureDate { get; set; }

    [StringLength(1000)]
    public string? DestinationCountryCode { get; set; }

    [StringLength(1000)]
    public string? ExporterSAddress { get; set; }

    [StringLength(1000)]
    public string? ExporterSCountryCode { get; set; }

    [StringLength(1000)]
    public string? ExporterSName { get; set; }

    [StringLength(1000)]
    public string? ExporterSTin { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantSId { get; set; }

    [StringLength(1000)]
    public string? FreeTextReservedForTheDeclarant { get; set; }

    [Range(-999999999, 999999999)]
    public double? GrossWeight { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IssuanceDate { get; set; }

    [StringLength(1000)]
    public string? IssuingOrganizationOfTheCertificateOfOrigin { get; set; }

    [StringLength(1000)]
    public string? MeansOfTransportNumber { get; set; }

    [StringLength(1000)]
    public string? MeansOfTransportTypeCode { get; set; }

    [StringLength(1000)]
    public string? OriginCountryCode { get; set; }

    [StringLength(1000)]
    public string? PreferentialCode { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? RecipientSAddress { get; set; }

    [StringLength(1000)]
    public string? RecipientSName { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RemarkContent { get; set; }

    [StringLength(1000)]
    public string? RequestDate { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TinOfTheDestination { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

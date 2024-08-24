namespace Control.APIs.Dtos;

public class CommonOriginCertificateRequestUpdateInput
{
    public string? AttachedFileId { get; set; }

    public string? AuthorizedExporterSAuthorizationNumber { get; set; }

    public string? CertificateOfOriginNumber { get; set; }

    public string? CertificateOfOriginRequestNumber { get; set; }

    public string? CodeOfTheGrossWeightUnit { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CustomsOfficeCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DeclarantSAddress { get; set; }

    public string? DeclarantSCode { get; set; }

    public string? DeclarantSName { get; set; }

    public string? DepartureDate { get; set; }

    public string? DestinationCountryCode { get; set; }

    public List<string>? Details { get; set; }

    public string? ExporterSAddress { get; set; }

    public string? ExporterSCountryCode { get; set; }

    public string? ExporterSName { get; set; }

    public string? ExporterSTin { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRegistrantSId { get; set; }

    public string? FreeTextReservedForTheDeclarant { get; set; }

    public double? GrossWeight { get; set; }

    public string? Id { get; set; }

    public string? IssuanceDate { get; set; }

    public string? IssuingOrganizationOfTheCertificateOfOrigin { get; set; }

    public string? MeansOfTransportNumber { get; set; }

    public string? MeansOfTransportTypeCode { get; set; }

    public string? OriginCountryCode { get; set; }

    public string? PreferentialCode { get; set; }

    public string? ProcessingStatusCode { get; set; }

    public string? RecipientSAddress { get; set; }

    public string? RecipientSName { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RemarkContent { get; set; }

    public string? Request { get; set; }

    public string? RequestDate { get; set; }

    public string? SuppressionOn { get; set; }

    public string? TinOfTheDestination { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

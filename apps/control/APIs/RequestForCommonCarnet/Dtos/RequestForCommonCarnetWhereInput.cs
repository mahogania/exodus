namespace Control.APIs.Dtos;

public class RequestForCommonCarnetWhereInput
{
    public List<string>? ArticleCarnetRequests { get; set; }

    public string? AttachedFileId { get; set; }

    public List<string>? CarnetControls { get; set; }

    public string? CertificationOrganization { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CustomsOfficeCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DeletionOn { get; set; }

    public string? DepartureCountryCode { get; set; }

    public string? DepartureCountryCode_1 { get; set; }

    public string? DepartureCountryCode_2 { get; set; }

    public string? DepartureCountryCode_3 { get; set; }

    public string? DepartureOfficeCode_2 { get; set; }

    public string? DepartureOfficeCode_3 { get; set; }

    public string? DepartureOffice_1 { get; set; }

    public string? DepartureOffice_2 { get; set; }

    public string? DepartureOffice_3 { get; set; }

    public string? DestinationCountryCode { get; set; }

    public string? DestinationCountryCode_1 { get; set; }

    public string? DestinationCountryCode_2 { get; set; }

    public string? DestinationCountryCode_3 { get; set; }

    public string? DestinationOfficeCode_1 { get; set; }

    public string? DestinationOfficeCode_2 { get; set; }

    public string? DestinationOfficeCode_3 { get; set; }

    public string? DestinationOffice_1 { get; set; }

    public string? DestinationOffice_2 { get; set; }

    public string? DestinationOffice_3 { get; set; }

    public double? Destination_1TransportQuantity { get; set; }

    public double? Destination_2TransportQuantity { get; set; }

    public double? Destination_3TransportQuantity { get; set; }

    public List<string>? ExtendedPeriodCarnetRequests { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public string? HolderSAddress { get; set; }

    public string? HolderSIdentificationNumber { get; set; }

    public string? HolderSName { get; set; }

    public string? HolderSZipcode { get; set; }

    public string? Id { get; set; }

    public List<string>? ImportCarnetRequests { get; set; }

    public string? InternationalOrganizationName { get; set; }

    public string? IssueDate { get; set; }

    public string? IssuedBy { get; set; }

    public string? NumberOfContainerConcerned { get; set; }

    public string? Observations { get; set; }

    public string? OfficialUse { get; set; }

    public List<string>? ReexportCarnetRequests { get; set; }

    public string? RegistrationDate { get; set; }

    public string? RegistrationNumber { get; set; }

    public string? SealNumber { get; set; }

    public string? StatusProcessingCode { get; set; }

    public string? TirNumber { get; set; }

    public string? TirRegistrationNumber { get; set; }

    public double? TotalNumberOfGoods { get; set; }

    public List<string>? TransitCarnetRequests { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? ValidUntil { get; set; }

    public string? VehicleCertificationNoAndDate { get; set; }
}

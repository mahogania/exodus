using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("CommonCarnetRequests")]
public class CommonCarnetRequestDbModel
{
    [StringLength(1000)]
    public string? AttachedFileId { get; set; }

    [StringLength(1000)]
    public string? CertificationOrganization { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsOfficeCode { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? DepartureCountryCode { get; set; }

    [StringLength(1000)]
    public string? DepartureCountryCode_1 { get; set; }

    [StringLength(1000)]
    public string? DepartureCountryCode_2 { get; set; }

    [StringLength(1000)]
    public string? DepartureCountryCode_3 { get; set; }

    [StringLength(1000)]
    public string? DepartureOfficeCode_2 { get; set; }

    [StringLength(1000)]
    public string? DepartureOfficeCode_3 { get; set; }

    [StringLength(1000)]
    public string? DepartureOffice_1 { get; set; }

    [StringLength(1000)]
    public string? DepartureOffice_2 { get; set; }

    [StringLength(1000)]
    public string? DepartureOffice_3 { get; set; }

    [StringLength(1000)]
    public string? DestinationCountryCode { get; set; }

    [StringLength(1000)]
    public string? DestinationCountryCode_1 { get; set; }

    [StringLength(1000)]
    public string? DestinationCountryCode_2 { get; set; }

    [StringLength(1000)]
    public string? DestinationCountryCode_3 { get; set; }

    [StringLength(1000)]
    public string? DestinationOfficeCode_1 { get; set; }

    [StringLength(1000)]
    public string? DestinationOfficeCode_2 { get; set; }

    [StringLength(1000)]
    public string? DestinationOfficeCode_3 { get; set; }

    [StringLength(1000)]
    public string? DestinationOffice_1 { get; set; }

    [StringLength(1000)]
    public string? DestinationOffice_2 { get; set; }

    [StringLength(1000)]
    public string? DestinationOffice_3 { get; set; }

    [Range(-999999999, 999999999)]
    public double? Destination_1TransportQuantity { get; set; }

    [Range(-999999999, 999999999)]
    public double? Destination_2TransportQuantity { get; set; }

    [Range(-999999999, 999999999)]
    public double? Destination_3TransportQuantity { get; set; }

    public List<ExtendedPeriodCarnetRequestDbModel>? ExtendedPeriodCarnetRequests { get; set; } =
        new List<ExtendedPeriodCarnetRequestDbModel>();

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderSId { get; set; }

    [StringLength(1000)]
    public string? HolderSAddress { get; set; }

    [StringLength(1000)]
    public string? HolderSIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? HolderSName { get; set; }

    [StringLength(1000)]
    public string? HolderSZipcode { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InternationalOrganizationName { get; set; }

    [StringLength(1000)]
    public string? IssueDate { get; set; }

    [StringLength(1000)]
    public string? IssuedBy { get; set; }

    [StringLength(1000)]
    public string? NumberOfContainerConcerned { get; set; }

    [StringLength(1000)]
    public string? Observations { get; set; }

    [StringLength(1000)]
    public string? OfficialUse { get; set; }

    [StringLength(1000)]
    public string? RegistrationDate { get; set; }

    [StringLength(1000)]
    public string? RegistrationNumber { get; set; }

    [StringLength(1000)]
    public string? SealNumber { get; set; }

    [StringLength(1000)]
    public string? StatusProcessingCode { get; set; }

    [StringLength(1000)]
    public string? TirNumber { get; set; }

    [StringLength(1000)]
    public string? TirRegistrationNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalNumberOfGoods { get; set; }

    public List<TransitCarnetRequestDbModel>? TransitCarnetRequests { get; set; } =
        new List<TransitCarnetRequestDbModel>();

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? ValidUntil { get; set; }

    [StringLength(1000)]
    public string? VehicleCertificationNoAndDate { get; set; }
}

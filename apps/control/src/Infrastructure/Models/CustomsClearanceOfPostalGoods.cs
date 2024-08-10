using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("CustomsClearanceOfPostalGoods")]
public class CustomsClearanceOfPostalGoodsDbModel
{
    [StringLength(1000)] public string? ArrivalDate { get; set; }

    [StringLength(1000)] public string? AttachedFileId { get; set; }

    [StringLength(1000)] public string? BagIdentifier { get; set; }

    [StringLength(1000)] public string? CategoryCode { get; set; }

    [StringLength(1000)] public string? CategoryOfTreatmentCode { get; set; }

    [StringLength(1000)] public string? CodeOfPostOfficeHandlingInternationalParcels { get; set; }

    [StringLength(1000)] public string? CountryOfOriginCode { get; set; }

    [StringLength(1000)] public string? CountryOfShipmentCode { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? CurrencyCodeForPostalPackageValue { get; set; }

    [StringLength(1000)] public string? CustomsOfficeCode { get; set; }

    [StringLength(1000)] public string? DeclaredCurrencyCodeForInsurance { get; set; }

    [Range(-999999999, 999999999)] public double? DeclaredInsuranceAmount { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    [StringLength(1000)] public string? DestinationRouting { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [StringLength(1000)] public string? FirstRecorderSId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [StringLength(1000)] public string? FlightNumber { get; set; }

    [Range(-999999999, 999999999)] public double? GrossWeight { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? ImportExportTypeCode { get; set; }

    [StringLength(1000)] public string? MailClass { get; set; }

    [StringLength(1000)] public string? ModeOfTransportCode { get; set; }

    [StringLength(1000)] public string? NameOfOriginPostOffice { get; set; }

    [StringLength(1000)] public string? NameOfPostOfficeHandlingInternationalParcels { get; set; }

    [StringLength(1000)] public string? Observations { get; set; }

    [StringLength(1000)] public string? OperationType { get; set; }

    [StringLength(1000)] public string? OrdinaryCustomsClearanceOn { get; set; }

    [StringLength(1000)] public string? OriginPost { get; set; }

    [StringLength(1000)] public string? PostalNumber { get; set; }

    [StringLength(1000)] public string? PostalPackageCustomsClearanceRequestNumber { get; set; }

    [Range(-999999999, 999999999)] public double? PostalPackageValue { get; set; }

    [StringLength(1000)] public string? ReceiverSEmail { get; set; }

    [StringLength(1000)] public string? ReceiverSId { get; set; }

    public DateTime? ReceptionDateAlgerPort { get; set; }

    [StringLength(1000)] public string? RecipientAddressAddress1 { get; set; }

    [StringLength(1000)] public string? RecipientAddressAddress2 { get; set; }

    [StringLength(1000)] public string? RecipientAddressCity { get; set; }

    [StringLength(1000)] public string? RecipientAddressCountryCode { get; set; }

    [StringLength(1000)] public string? RecipientSFixedPhoneNumber { get; set; }

    [StringLength(1000)] public string? RecipientSPostalCode { get; set; }

    [StringLength(1000)] public string? RequestDate { get; set; }

    [StringLength(1000)] public string? RequesterSId { get; set; }

    [StringLength(1000)] public string? ShipperSAddress { get; set; }

    [StringLength(1000)] public string? ShipperSAddress_2 { get; set; }

    [StringLength(1000)] public string? ShipperSCity { get; set; }

    [StringLength(1000)] public string? ShipperSEmail { get; set; }

    [StringLength(1000)] public string? ShipperSId { get; set; }

    [StringLength(1000)] public string? ShipperSName { get; set; }

    [StringLength(1000)] public string? ShipperSPhoneNumber { get; set; }

    [StringLength(1000)] public string? ShipperSPostalCode { get; set; }

    public DateTime? ShippingDate { get; set; }

    [StringLength(1000)] public string? SimplifiedCustomsClearanceOn { get; set; }

    [Range(-999999999, 999999999)] public double? TotalTaxAmount { get; set; }

    public DateTime? TransportDate { get; set; }

    [StringLength(1000)] public string? TreatmentCode { get; set; }

    [StringLength(1000)] public string? TreatmentStatusCode { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

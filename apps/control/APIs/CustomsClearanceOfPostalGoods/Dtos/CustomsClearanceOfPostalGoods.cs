namespace Control.APIs.Dtos;

public class CustomsClearanceOfPostalGoods
{
    public string? ArrivalDate { get; set; }

    public string? AttachedFileId { get; set; }

    public string? BagIdentifier { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryOfTreatmentCode { get; set; }

    public string? CodeOfPostOfficeHandlingInternationalParcels { get; set; }

    public string? CountryOfOriginCode { get; set; }

    public string? CountryOfShipmentCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CurrencyCodeForPostalPackageValue { get; set; }

    public string? CustomsOfficeCode { get; set; }

    public string? DeclaredCurrencyCodeForInsurance { get; set; }

    public double? DeclaredInsuranceAmount { get; set; }

    public string? DeletionOn { get; set; }

    public string? DestinationRouting { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? FlightNumber { get; set; }

    public double? GrossWeight { get; set; }

    public string Id { get; set; }

    public string? ImportExportTypeCode { get; set; }

    public string? MailClass { get; set; }

    public string? ModeOfTransportCode { get; set; }

    public string? NameOfOriginPostOffice { get; set; }

    public string? NameOfPostOfficeHandlingInternationalParcels { get; set; }

    public string? Observations { get; set; }

    public string? OperationType { get; set; }

    public string? OrdinaryCustomsClearanceOn { get; set; }

    public string? OriginPost { get; set; }

    public List<string>? PostalGoodsClearanceDetails { get; set; }

    public string? PostalNumber { get; set; }

    public string? PostalPackageCustomsClearanceRequestNumber { get; set; }

    public double? PostalPackageValue { get; set; }

    public string? Procedure { get; set; }

    public string? ReceiverSEmail { get; set; }

    public string? ReceiverSId { get; set; }

    public DateTime? ReceptionDateAlgerPort { get; set; }

    public string? RecipientAddressAddress1 { get; set; }

    public string? RecipientAddressAddress2 { get; set; }

    public string? RecipientAddressCity { get; set; }

    public string? RecipientAddressCountryCode { get; set; }

    public string? RecipientSFixedPhoneNumber { get; set; }

    public string? RecipientSPostalCode { get; set; }

    public string? RequestDate { get; set; }

    public string? RequesterSId { get; set; }

    public string? ShipperSAddress { get; set; }

    public string? ShipperSAddress_2 { get; set; }

    public string? ShipperSCity { get; set; }

    public string? ShipperSEmail { get; set; }

    public string? ShipperSId { get; set; }

    public string? ShipperSName { get; set; }

    public string? ShipperSPhoneNumber { get; set; }

    public string? ShipperSPostalCode { get; set; }

    public DateTime? ShippingDate { get; set; }

    public string? SimplifiedCustomsClearanceOn { get; set; }

    public double? TotalTaxAmount { get; set; }

    public DateTime? TransportDate { get; set; }

    public string? TreatmentCode { get; set; }

    public string? TreatmentStatusCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}

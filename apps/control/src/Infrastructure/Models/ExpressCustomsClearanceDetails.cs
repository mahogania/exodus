using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ExpressCustomsClearanceDetails")]
public class ExpressCustomsClearanceDetailsDbModel
{
    [StringLength(1000)]
    public string? BarcodeContent { get; set; }

    public DateTime? BarcodeTransmissionDateAndTime { get; set; }

    [StringLength(1000)]
    public string? CarrierCode { get; set; }

    [StringLength(1000)]
    public string? CommercialDenomination { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsClearanceCode { get; set; }

    [StringLength(1000)]
    public string? CustomsNote { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? ECommercialWebsite { get; set; }

    [StringLength(1000)]
    public string? ElectronicCommercialEnterpriseCertificationNumber { get; set; }

    [StringLength(1000)]
    public string? ExpressCustomsClearanceRequestNumber { get; set; }

    [StringLength(1000)]
    public string? ExpressCustomsClearanceTypeCode { get; set; }

    [StringLength(1000)]
    public string? ExpressOperatorCode { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [Range(-999999999, 999999999)]
    public double? GoodsValue { get; set; }

    [StringLength(1000)]
    public string? HouseBlNumber { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdDuPremierEnregistrant { get; set; }

    [StringLength(1000)]
    public string? MasterBlNumber { get; set; }

    [StringLength(1000)]
    public string? OperationType { get; set; }

    [StringLength(1000)]
    public string? OrdinaryCustomsClearanceOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? PackageQuantity { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? PurposeTypeCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? Quantity { get; set; }

    [StringLength(1000)]
    public string? RecipientSAddress { get; set; }

    [StringLength(1000)]
    public string? RecipientSIdentificationCode { get; set; }

    [StringLength(1000)]
    public string? RecipientSName { get; set; }

    [StringLength(1000)]
    public string? RecipientSPhoneNumber { get; set; }

    [StringLength(1000)]
    public string? RecipientSPostalCode { get; set; }

    [StringLength(1000)]
    public string? SenderSAddress { get; set; }

    [StringLength(1000)]
    public string? SenderSName { get; set; }

    [StringLength(1000)]
    public string? SenderSPhoneNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? SequenceNumber { get; set; }

    [StringLength(1000)]
    public string? ShCode { get; set; }

    [StringLength(1000)]
    public string? ShippingCountryCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? SimpleCustomsDutyAmount { get; set; }

    [StringLength(1000)]
    public string? SimplifiedCustomsClearanceOn { get; set; }

    [StringLength(1000)]
    public string? Standards { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? Weight { get; set; }
}

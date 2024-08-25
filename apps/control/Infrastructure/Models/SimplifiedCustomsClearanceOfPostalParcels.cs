using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("SimplifiedCustomsClearanceOfPostalParcels")]
public class SimplifiedCustomsClearanceOfPostalParcelsDbModel
{
    [StringLength(1000)] public string? AmountAndCurrencyCode { get; set; }

    [StringLength(1000)] public string? ApplicationOfTheFreeTradeAgreementTariffOn { get; set; }

    [StringLength(1000)] public string? ArrivalDate { get; set; }

    [StringLength(1000)] public string? AttachedFileId { get; set; }

    [StringLength(1000)] public string? CodeOfPaymentMethod { get; set; }

    [StringLength(1000)] public string? CodeOfThePostOfficeHandlingInternationalParcels { get; set; }

    [StringLength(1000)]
    public string? CodeOfTypeOfArticlesSuspectedOfInfringingIntellectualPropertyRights { get; set; }

    [StringLength(1000)] public string? CodeOfTypeOfDestruction { get; set; }

    [StringLength(1000)] public string? CodeOfTypeOfReturn { get; set; }

    [StringLength(1000)] public string? CommercialName { get; set; }

    [StringLength(1000)] public string? ContentsOfOthers { get; set; }

    [StringLength(1000)] public string? CountryOfDispatchCode { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    [StringLength(1000)] public string? CustomsClearanceNumber { get; set; }

    [StringLength(1000)] public string? CustomsOfficeCode { get; set; }

    [StringLength(1000)] public string? CustomsSimplifiedClearanceRequestNumber { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)] public string? DeclarantSCode { get; set; }

    [StringLength(1000)] public string? DeclaredGoodsName { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [StringLength(1000)] public string? FirstRecorderSId { get; set; }

    [StringLength(1000)] public string? GiftsOn { get; set; }

    [Range(-999999999, 999999999)] public double? GrossWeight { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? NameOfThePostOfficeHandlingInternationalParcels { get; set; }

    [StringLength(1000)] public string? OthersOn { get; set; }

    [StringLength(1000)] public string? PersonalCustomsClearanceNumber { get; set; }

    [StringLength(1000)] public string? PersonalPurchaseOn { get; set; }

    [StringLength(1000)] public string? PostalParcelNumber { get; set; }

    [Range(-999999999, 999999999)] public double? Quantity { get; set; }

    [StringLength(1000)] public string? ReasonsForArticlesSuspectedOfInfringingIntellectualPropertyRights { get; set; }

    [StringLength(1000)] public string? RecipientSAddress { get; set; }

    [StringLength(1000)] public string? RecipientSName { get; set; }

    [StringLength(1000)] public string? RecipientSPhoneNumber { get; set; }

    [StringLength(1000)] public string? RecipientSPostalCode { get; set; }

    [StringLength(1000)] public string? ReintroductionOn { get; set; }

    [StringLength(1000)] public string? RequestDate { get; set; }

    [StringLength(1000)] public string? ReturnOrDestructionOn { get; set; }

    [StringLength(1000)] public string? SenderSName { get; set; }

    [StringLength(1000)] public string? Standards { get; set; }

    [StringLength(1000)] public string? StatusCodeOfProcessing { get; set; }

    [StringLength(1000)] public string? SuppressionOn { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)] public double? ValueOfPostalParcels { get; set; }

    [Range(-999999999, 999999999)] public double? Weight { get; set; }
}

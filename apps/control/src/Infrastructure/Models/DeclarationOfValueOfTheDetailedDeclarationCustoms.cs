using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("DeclarationOfValueOfTheDetailedDeclarationCustoms")]
public class DeclarationOfValueOfTheDetailedDeclarationCustomsDbModel
{
    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfMediationAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfOtherFeesForLoadingAtTheImportPort { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfOtherFeesForTechnologicalDesign { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfOtherToolFees { get; set; }

    [StringLength(1000)]
    public string? AdditionalCostOfPurchaseCommissionOn { get; set; }

    [StringLength(1000)]
    public string? AdditionalCostOfSalesCommissionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfTheAmountOfFreightFromTheImportPort { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfTheAmountOfInsuranceFromTheImportPort { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfTheCostOfComponentsOfTheMaterials { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfTheCostOfConsumableGoods { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfTheCostOfPackagesAndContainers { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfTheCostOfProcessing { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfTheLicenseFee { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfTheSellerSProfitAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? AdditionalCostOfTransportCost { get; set; }

    [Range(-999999999, 999999999)]
    public double? BaseForCalculatingIndirectAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? BaseForCalculatingTotalAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? BaseForCalculatingTransactionalValue { get; set; }

    [StringLength(1000)]
    public string? BuyerSIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? ComplementaryObservation { get; set; }

    [StringLength(1000)]
    public string? ContractConclusionDate { get; set; }

    [StringLength(1000)]
    public string? ContractNumber { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DateOfIssuanceOfTheInvoice { get; set; }

    [StringLength(1000)]
    public string? DateOfIssuanceOfTheOfficialLetterOfPreliminaryDecision { get; set; }

    [StringLength(1000)]
    public string? DeclarantSName { get; set; }

    [StringLength(1000)]
    public string? DeclarationDate { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredStatisticalValue { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductedAmountOfCustomsDutiesOfTheExportingCountry { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductedOtherFees { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductedOtherServices { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductedTotalAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeductedTransportCost { get; set; }

    [StringLength(1000)]
    public string? DeliveryConditionCode { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderSId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InvoiceNumber { get; set; }

    [StringLength(1000)]
    public string? NumberOfTheOfficialLetterOfPreliminaryDecision { get; set; }

    [StringLength(1000)]
    public string? OtherExplanations { get; set; }

    [StringLength(1000)]
    public string? PlaceOfDeclarationName { get; set; }

    [StringLength(1000)]
    public string? Question_1On { get; set; }

    [StringLength(1000)]
    public string? Question_2On { get; set; }

    [StringLength(1000)]
    public string? Question_3On { get; set; }

    [StringLength(1000)]
    public string? Question_4On { get; set; }

    [StringLength(1000)]
    public string? Question_5On { get; set; }

    [StringLength(1000)]
    public string? Question_6On { get; set; }

    [StringLength(1000)]
    public string? Question_7On { get; set; }

    [StringLength(1000)]
    public string? Question_8On { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? SellerSIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? SpecifyTheNatureOfTheRestrictions { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalDeductedAmountOfAdditionalCosts { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

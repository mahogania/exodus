using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("TemporaryAdmissionForPerfections")]
public class TemporaryAdmissionForPerfectionDbModel
{
    [StringLength(1000)] public string? ActivePerfectionRepairPerformedByThirdParty { get; set; }

    [StringLength(1000)] public string? Address { get; set; }

    [StringLength(1000)] public string? ApcCode { get; set; }

    [StringLength(1000)] public string? Applicant { get; set; }

    [StringLength(1000)] public string? ApplicantNature { get; set; }

    [StringLength(1000)] public string? CessionDecisionDeliveryDate { get; set; }

    [StringLength(1000)] public string? CessionDecisionNumber { get; set; }

    [StringLength(1000)] public string? CommerceRegistryNumber { get; set; }

    [Range(-999999999, 999999999)] public double? ContributionRate { get; set; }

    [Required] public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)] public string? DeletionOn { get; set; }

    [StringLength(1000)] public string? DomiciliaryBankAddress { get; set; }

    [StringLength(1000)] public string? DomiciliaryBankLegalName { get; set; }

    [StringLength(1000)] public string? EndDateOfRegimeAuthorization { get; set; }

    [StringLength(1000)] public string? EpcCode { get; set; }

    [StringLength(1000)] public string? EstablishmentAddress { get; set; }

    [StringLength(1000)] public string? ExportCustomsOffice { get; set; }

    [StringLength(1000)] public string? ExportOperationPaymentMode { get; set; }

    [StringLength(1000)] public string? FinalModifierSId { get; set; }

    [Range(-999999999, 999999999)] public double? FinishedProductWasteRate { get; set; }

    [StringLength(1000)] public string? FirstRecorderSId { get; set; }

    [Range(-999999999, 999999999)]
    public double? ForeignOriginMaterialQuantitiesRateAcquiredOnNationalMarket { get; set; }

    [StringLength(1000)] public string? GoodsFromAnotherRde { get; set; }

    [Key] [Required] public string Id { get; set; }

    [StringLength(1000)] public string? ImportCustomsOffice { get; set; }

    [StringLength(1000)] public string? ImportOperationFinancingMode { get; set; }

    [Range(-999999999, 999999999)] public double? ImportedMaterialQuantitiesRate { get; set; }

    [Range(-999999999, 999999999)] public double? ImportedPackagingQuantitiesRate { get; set; }

    [StringLength(1000)] public string? LocalAddress { get; set; }

    [Range(-999999999, 999999999)] public double? LossRate { get; set; }

    [StringLength(1000)] public string? NameAndLegalNameOfThirdParty { get; set; }

    [StringLength(1000)]
    public string? NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepaired { get; set; }

    [StringLength(1000)]
    public string? NameLegalNameOfEstablishmentWhereImportedGoodsMustBeTransformedRepairedByThirdParty { get; set; }

    [Range(-999999999, 999999999)] public double? NationalOriginMaterialQuantitiesRate { get; set; }

    [StringLength(1000)] public string? NatureOfOperation { get; set; }

    [StringLength(1000)] public string? NatureOfOperationPerformedByThirdParty { get; set; }

    [StringLength(1000)] public string? Nif { get; set; }

    [StringLength(1000)] public string? NifStatus { get; set; }

    [Range(-999999999, 999999999)] public double? NonRecoverableWasteRate { get; set; }

    [Range(-999999999, 999999999)] public double? PlannedTotalAmountForTransformationRepair { get; set; }

    [StringLength(1000)] public string? RcStatus { get; set; }

    [Range(-999999999, 999999999)] public double? RecoverableWasteRate { get; set; }

    [Range(-999999999, 999999999)] public double? RectificationFrequency { get; set; }

    [StringLength(1000)] public string? RegimeAuthorizationNumber { get; set; }

    [StringLength(1000)] public string? RequestRegimeNumber { get; set; }

    [StringLength(1000)] public string? RequestedActivePerfectionType { get; set; }

    [StringLength(1000)] public string? RequestedAuthorizationType { get; set; }

    [StringLength(1000)] public string? RequestedEndDate { get; set; }

    [StringLength(1000)] public string? RequestedStartDate { get; set; }

    [StringLength(1000)] public string? StartDateOfRegimeAuthorization { get; set; }

    [StringLength(1000)] public string? TransferWithMaintenanceOfRegime { get; set; }

    [Required] public DateTime UpdatedAt { get; set; }
}

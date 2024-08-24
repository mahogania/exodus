using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("CommonDetailedDeclarations")]
public class CommonDetailedDeclarationDbModel
{
    public DateTime? ArrivalDate { get; set; }

    public List<ArticleDbModel>? Articles { get; set; } = new List<ArticleDbModel>();

    public List<ExpectedReimportReexportArticleDbModel>? ArticlesExpectedForReImportExport { get; set; } =
        new List<ExpectedReimportReexportArticleDbModel>();

    public string? AssessmentId { get; set; }

    [ForeignKey(nameof(AssessmentId))]
    public ValueAssessmentDbModel? Assessment { get; set; } = null;

    [StringLength(1000)]
    public string? BankAgencyCode { get; set; }

    [StringLength(1000)]
    public string? BillOfLadingDate { get; set; }

    [StringLength(1000)]
    public string? BillOfLadingNumber { get; set; }

    [StringLength(1000)]
    public string? ConditionCode_2 { get; set; }

    public string? ContainerId { get; set; }

    [ForeignKey(nameof(ContainerId))]
    public ContainerOfTheDetailedDeclarationCustomsDbModel? Container { get; set; } = null;

    [StringLength(1000)]
    public string? ContainerizedCargoOn { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Crn { get; set; }

    [StringLength(1000)]
    public string? CustomsClearancePlanCode { get; set; }

    [StringLength(1000)]
    public string? CustomsDeclarationSuppressionOn { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    [StringLength(1000)]
    public string? DeclarantCode { get; set; }

    [StringLength(1000)]
    public string? DeclarantSReservedFreeText { get; set; }

    [StringLength(1000)]
    public string? DeclarantsReservedFreeText { get; set; }

    [StringLength(1000)]
    public string? DeclarationFormCode { get; set; }

    [StringLength(1000)]
    public string? DeclarationOfficeCode { get; set; }

    [StringLength(1000)]
    public string? DeclarationTypeCode { get; set; }

    [StringLength(1000)]
    public string? DeliveryConditionCode { get; set; }

    [StringLength(1000)]
    public string? DeliveryLocationCode { get; set; }

    [StringLength(1000)]
    public string? DestinationCountryCode { get; set; }

    [StringLength(1000)]
    public string? DetailedDeclarationNumber { get; set; }

    public string? DocumentId { get; set; }

    [ForeignKey(nameof(DocumentId))]
    public JointDocumentDbModel? Document { get; set; } = null;

    public DateTime? DomiciliationDate { get; set; }

    [StringLength(1000)]
    public string? DomiciliationStatusCode { get; set; }

    [StringLength(1000)]
    public string? EntryAndExitOfficeCode { get; set; }

    [StringLength(1000)]
    public string? EpcCode { get; set; }

    [StringLength(1000)]
    public string? ExporterSCommercialRegistryNumber { get; set; }

    [StringLength(1000)]
    public string? ExporterSIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? ExporterSIdentificationNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ExportersCommercialRegistryNumber { get; set; }

    [StringLength(1000)]
    public string? ExportersIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? ExportersIdentificationNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ExportingCountryCode { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FinalModifiersId { get; set; }

    [StringLength(1000)]
    public string? FinalOn { get; set; }

    [StringLength(1000)]
    public string? FinancingMode { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderSId { get; set; }

    [StringLength(1000)]
    public string? FirstRecordersId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdentificationNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ImporterSCommercialRegistryNumber { get; set; }

    [StringLength(1000)]
    public string? ImporterSIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? ImporterSIdentificationNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ImportersCommercialRegistryNumber { get; set; }

    [StringLength(1000)]
    public string? ImportersIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? InitialDeclarationDate { get; set; }

    [StringLength(1000)]
    public string? InvoiceIssuanceDate { get; set; }

    [StringLength(1000)]
    public string? InvoiceNumber { get; set; }

    public JournalDbModel Journal { get; set; } = null;

    [StringLength(1000)]
    public string? LoadingLocationCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? ManagementAndMonitoringClearancePeriod { get; set; }

    [StringLength(1000)]
    public string? MeansOfTransportIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? MeansOfTransportIdentificationNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? MeansOfTransportNationalityCode { get; set; }

    [StringLength(1000)]
    public string? ModificationReasonCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfContainers { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfItems { get; set; }

    [StringLength(1000)]
    public string? OperationType { get; set; }

    public string? OperatorId { get; set; }

    [ForeignKey(nameof(OperatorId))]
    public OperatorDbModel? Operator { get; set; } = null;

    [StringLength(1000)]
    public string? PartialCustomsClearanceTypeCode { get; set; }

    [StringLength(1000)]
    public string? PaymentAccountNumber { get; set; }

    [StringLength(1000)]
    public string? PaymentBankAgencyCode { get; set; }

    [StringLength(1000)]
    public string? PaymentBankCode { get; set; }

    [StringLength(1000)]
    public string? PaymentModeCode { get; set; }

    [StringLength(1000)]
    public string? PreviousBondedWarehouseCode { get; set; }

    [StringLength(1000)]
    public string? PreviousCustomsBondedWarehouseCode { get; set; }

    [StringLength(1000)]
    public string? RecipientRegionCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RectificationReason { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)]
    public string? RequestDate { get; set; }

    [StringLength(1000)]
    public string? SeizedValueDeclarationOn { get; set; }

    [StringLength(1000)]
    public string? SelfLiquidationOn { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [StringLength(1000)]
    public string? ShipName { get; set; }

    [StringLength(1000)]
    public string? ShippingCountryCode { get; set; }

    [StringLength(1000)]
    public string? StorageLocationCode { get; set; }

    [StringLength(1000)]
    public string? SuppressionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? SystemUsageTime { get; set; }

    [StringLength(1000)]
    public string? TaxIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? TaxpayerIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? TaxpayerSCommercialRegistryNumber { get; set; }

    [StringLength(1000)]
    public string? TaxpayerSIdentificationNumber { get; set; }

    [StringLength(1000)]
    public string? TaxpayersCommercialRegistryNumber { get; set; }

    [StringLength(1000)]
    public string? TaxpayersIdentificationNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalGrossWeight { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalNetWeight { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalNumberOfPackages { get; set; }

    [StringLength(1000)]
    public string? TransactionConditionCode_1 { get; set; }

    [StringLength(1000)]
    public string? TransactionConditionCode_2 { get; set; }

    [StringLength(1000)]
    public string? TransactionCountryCode { get; set; }

    [StringLength(1000)]
    public string? TravelerProcessingText { get; set; }

    [StringLength(1000)]
    public string? TravelerReferenceNumber { get; set; }

    [StringLength(1000)]
    public string? UnloadingDate { get; set; }

    [StringLength(1000)]
    public string? UnloadingLocationCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    public string? ValueDeclarationId { get; set; }

    [ForeignKey(nameof(ValueDeclarationId))]
    public ValueDeclarationDbModel? ValueDeclaration { get; set; } = null;

    [StringLength(1000)]
    public string? ValueDeclarationOn { get; set; }

    [StringLength(1000)]
    public string? VehiclePickupOn { get; set; }
}

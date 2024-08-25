namespace Control.APIs.Dtos;

public class CommonDetailedDeclarationCreateInput
{
    public DateTime? ArrivalDate { get; set; }

    public List<Article>? Articles { get; set; }

    public List<ExpectedReimportReexportArticle>? ArticlesExpectedForReImportExport { get; set; }

    public ValueAssessment? Assessment { get; set; }

    public string? BankAgencyCode { get; set; }

    public string? BillOfLadingDate { get; set; }

    public string? BillOfLadingNumber { get; set; }

    public string? ConditionCode_2 { get; set; }

    public ContainerOfTheDetailedDeclarationCustoms? Container { get; set; }

    public string? ContainerizedCargoOn { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Crn { get; set; }

    public string? CustomsClearancePlanCode { get; set; }

    public string? CustomsDeclarationSuppressionOn { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public string? DeclarantCode { get; set; }

    public string? DeclarantSReservedFreeText { get; set; }

    public string? DeclarantsReservedFreeText { get; set; }

    public string? DeclarationFormCode { get; set; }

    public string? DeclarationOfficeCode { get; set; }

    public string? DeclarationTypeCode { get; set; }

    public string? DeliveryConditionCode { get; set; }

    public string? DeliveryLocationCode { get; set; }

    public string? DestinationCountryCode { get; set; }

    public string? DetailedDeclarationNumber { get; set; }

    public JointDocument? Document { get; set; }

    public DateTime? DomiciliationDate { get; set; }

    public string? DomiciliationStatusCode { get; set; }

    public string? EntryAndExitOfficeCode { get; set; }

    public string? EpcCode { get; set; }

    public string? ExporterSCommercialRegistryNumber { get; set; }

    public string? ExporterSIdentificationNumber { get; set; }

    public string? ExporterSIdentificationNumberTypeCode { get; set; }

    public string? ExportersCommercialRegistryNumber { get; set; }

    public string? ExportersIdentificationNumber { get; set; }

    public string? ExportersIdentificationNumberTypeCode { get; set; }

    public string? ExportingCountryCode { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FinalModifiersId { get; set; }

    public string? FinalOn { get; set; }

    public string? FinancingMode { get; set; }

    public string? FirstRecorderSId { get; set; }

    public string? FirstRecordersId { get; set; }

    public string? Id { get; set; }

    public string? IdentificationNumberTypeCode { get; set; }

    public string? ImporterSCommercialRegistryNumber { get; set; }

    public string? ImporterSIdentificationNumber { get; set; }

    public string? ImporterSIdentificationNumberTypeCode { get; set; }

    public string? ImportersCommercialRegistryNumber { get; set; }

    public string? ImportersIdentificationNumber { get; set; }

    public string? InitialDeclarationDate { get; set; }

    public string? InvoiceIssuanceDate { get; set; }

    public string? InvoiceNumber { get; set; }

    public Procedure Journal { get; set; }

    public string? LoadingLocationCode { get; set; }

    public double? ManagementAndMonitoringClearancePeriod { get; set; }

    public string? MeansOfTransportIdentificationNumber { get; set; }

    public string? MeansOfTransportIdentificationNumberTypeCode { get; set; }

    public string? MeansOfTransportNationalityCode { get; set; }

    public string? ModificationReasonCode { get; set; }

    public double? NumberOfContainers { get; set; }

    public double? NumberOfItems { get; set; }

    public string? OperationType { get; set; }

    public Operator? Operator { get; set; }

    public string? PartialCustomsClearanceTypeCode { get; set; }

    public string? PaymentAccountNumber { get; set; }

    public string? PaymentBankAgencyCode { get; set; }

    public string? PaymentBankCode { get; set; }

    public string? PaymentModeCode { get; set; }

    public string? PreviousBondedWarehouseCode { get; set; }

    public string? PreviousCustomsBondedWarehouseCode { get; set; }

    public string? RecipientRegionCode { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RectificationReason { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public string? RequestDate { get; set; }

    public string? SeizedValueDeclarationOn { get; set; }

    public string? SelfLiquidationOn { get; set; }

    public string? ServiceCode { get; set; }

    public string? ShipName { get; set; }

    public string? ShippingCountryCode { get; set; }

    public string? StorageLocationCode { get; set; }

    public string? SuppressionOn { get; set; }

    public double? SystemUsageTime { get; set; }

    public string? TaxIdentificationNumber { get; set; }

    public string? TaxpayerIdentificationNumber { get; set; }

    public string? TaxpayerSCommercialRegistryNumber { get; set; }

    public string? TaxpayerSIdentificationNumber { get; set; }

    public string? TaxpayersCommercialRegistryNumber { get; set; }

    public string? TaxpayersIdentificationNumber { get; set; }

    public double? TotalGrossWeight { get; set; }

    public double? TotalNetWeight { get; set; }

    public double? TotalNumberOfPackages { get; set; }

    public string? TransactionConditionCode_1 { get; set; }

    public string? TransactionConditionCode_2 { get; set; }

    public string? TransactionCountryCode { get; set; }

    public string? TravelerProcessingText { get; set; }

    public string? TravelerReferenceNumber { get; set; }

    public string? UnloadingDate { get; set; }

    public string? UnloadingLocationCode { get; set; }

    public DateTime UpdatedAt { get; set; }

    public ValueDeclaration? ValueDeclaration { get; set; }

    public string? ValueDeclarationOn { get; set; }

    public string? VehiclePickupOn { get; set; }
}

namespace Collection.APIs.Dtos;

public class ClaimedFineUpdateInput
{
    public string? AcceptedByTaxpayerOn { get; set; }

    public string? ApprovalId { get; set; }

    public string? AttachedFileId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? DeclarantCode { get; set; }

    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FinancialOfficerName { get; set; }

    public double? FineAmount { get; set; }

    public double? FineAmountInEur { get; set; }

    public double? FineAmountInUsd { get; set; }

    public string? FineImpositionRequestNumber { get; set; }

    public string? FineRegistrationReasonContent { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? NotificationRequiredOn { get; set; }

    public string? OfficeCode { get; set; }

    public string? OpinionRegisteredByTaxpayerOn { get; set; }

    public string? ReferenceDate { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? ReferenceNumberTypeCode { get; set; }

    public string? ReferenceNumberTypeName { get; set; }

    public string? RequestDate { get; set; }

    public string? RequestingPersonId { get; set; }

    public string? ServiceCode { get; set; }

    public DateTime? TaxpayerAcceptanceMoment { get; set; }

    public string? TaxpayerIdentificationNumber { get; set; }

    public string? TinCategoryCode { get; set; }

    public string? TinCategoryName { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

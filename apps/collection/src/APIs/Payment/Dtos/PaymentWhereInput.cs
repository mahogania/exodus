namespace Collection.APIs.Dtos;

public class PaymentWhereInput
{
    public string? AccountCode { get; set; }

    public string? BankAgencyCode { get; set; }

    public double? Cents { get; set; }

    public string? CheckNature { get; set; }

    public string? CheckType { get; set; }

    public string? CollectionBankCode { get; set; }

    public string? CollectionNo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public double? CreditInterest { get; set; }

    public double? CustomsDutiesTotalAmountToPay { get; set; }

    public string? DeletionOn { get; set; }

    public double? DetailSequenceNo { get; set; }

    public string? DueDate { get; set; }

    public double? FeeAmount { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierId { get; set; }

    public string? FinancialOfficerName { get; set; }

    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? ImportDeclarationDate { get; set; }

    public string? InspectionTaxCheckDate { get; set; }

    public string? InspectionTaxCheckNumber { get; set; }

    public string? NiuCategoryCode { get; set; }

    public string? OfficeCode { get; set; }

    public string? OrderNumber { get; set; }

    public double? PaidAmount { get; set; }

    public string? PaymentTypeCode { get; set; }

    public string? ServiceCode { get; set; }

    public string? TaxpayerIdentificationNo { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

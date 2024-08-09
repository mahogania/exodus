namespace Clre.APIs.Dtos;

public class StateOfGoodsForPassivePerfectionCommonUpdateInput
{
    public string? CompanyAddress { get; set; }

    public string? CompanyName { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CustomsCodeOfExportDeclaration { get; set; }

    public string? CustomsCodeOfImportDeclaration { get; set; }

    public string? DeletionOn { get; set; }

    public string? DocumentCode { get; set; }

    public string? EndDateOfGrantedDeadline { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public string? FinalModifierSId { get; set; }

    public string? FirstRecorderSId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public string? Id { get; set; }

    public string? NatureOfPassivePerfection { get; set; }

    public string? PaymentBankAgencyCode { get; set; }

    public string? PaymentBankCode { get; set; }

    public string? PaymentModeCode { get; set; }

    public string? ReasonsCitedInFavorOfTheOperation { get; set; }

    public double? RectificationFrequency { get; set; }

    public string? RegimeRequestNumber { get; set; }

    public string? SpecifyOtherPaymentMethods { get; set; }

    public string? StartDateOfGrantedDeadline { get; set; }

    public double? TotalAmount { get; set; }

    public string? TransactionValueCurrencyCode { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clre.Infrastructure.Models;

[Table("StateOfGoodsForPassivePerfectionCommons")]
public class StateOfGoodsForPassivePerfectionCommonDbModel
{
    [StringLength(1000)]
    public string? CompanyAddress { get; set; }

    [StringLength(1000)]
    public string? CompanyName { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CustomsCodeOfExportDeclaration { get; set; }

    [StringLength(1000)]
    public string? CustomsCodeOfImportDeclaration { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? DocumentCode { get; set; }

    [StringLength(1000)]
    public string? EndDateOfGrantedDeadline { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierSId { get; set; }

    [StringLength(1000)]
    public string? FirstRecorderSId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? NatureOfPassivePerfection { get; set; }

    [StringLength(1000)]
    public string? PaymentBankAgencyCode { get; set; }

    [StringLength(1000)]
    public string? PaymentBankCode { get; set; }

    [StringLength(1000)]
    public string? PaymentModeCode { get; set; }

    [StringLength(1000)]
    public string? ReasonsCitedInFavorOfTheOperation { get; set; }

    [Range(-999999999, 999999999)]
    public double? RectificationFrequency { get; set; }

    [StringLength(1000)]
    public string? RegimeRequestNumber { get; set; }

    [StringLength(1000)]
    public string? SpecifyOtherPaymentMethods { get; set; }

    [StringLength(1000)]
    public string? StartDateOfGrantedDeadline { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalAmount { get; set; }

    [StringLength(1000)]
    public string? TransactionValueCurrencyCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

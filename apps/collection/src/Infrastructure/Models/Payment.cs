using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Payments")]
public class PaymentDbModel
{
    [StringLength(1000)]
    public string? AccountCode { get; set; }

    [StringLength(1000)]
    public string? BankAgencyCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? Cents { get; set; }

    [StringLength(1000)]
    public string? CheckNature { get; set; }

    [StringLength(1000)]
    public string? CheckType { get; set; }

    [StringLength(1000)]
    public string? CollectionBankCode { get; set; }

    [StringLength(1000)]
    public string? CollectionNo { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? CreditInterest { get; set; }

    [Range(-999999999, 999999999)]
    public double? CustomsDutiesTotalAmountToPay { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? DetailSequenceNo { get; set; }

    [StringLength(1000)]
    public string? DueDate { get; set; }

    [Range(-999999999, 999999999)]
    public double? FeeAmount { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FinancialOfficerName { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ImportDeclarationDate { get; set; }

    [StringLength(1000)]
    public string? InspectionTaxCheckDate { get; set; }

    [StringLength(1000)]
    public string? InspectionTaxCheckNumber { get; set; }

    [StringLength(1000)]
    public string? NiuCategoryCode { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? OrderNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? PaidAmount { get; set; }

    [StringLength(1000)]
    public string? PaymentTypeCode { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [StringLength(1000)]
    public string? TaxpayerIdentificationNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

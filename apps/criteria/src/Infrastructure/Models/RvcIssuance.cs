using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("RvcIssuances")]
public class RvcIssuanceDbModel
{
    [StringLength(1000)]
    public string? AttachmentFileId { get; set; }

    [StringLength(1000)]
    public string? BlNumber { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredNcyFobAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredNcyFreightAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredNcyInsuranceAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredNcyOtherChargesAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? DeclaredNcyTotalTaxableBaseAmount { get; set; }

    [StringLength(1000)]
    public string? DeliveryConditionCode { get; set; }

    [StringLength(1000)]
    public string? ExporterAddress { get; set; }

    [StringLength(1000)]
    public string? ExporterCompanyName { get; set; }

    [StringLength(1000)]
    public string? ExporterCountryCode { get; set; }

    [StringLength(1000)]
    public string? ExporterIdentificationNumber { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ImporterAddress { get; set; }

    [StringLength(1000)]
    public string? ImporterCompanyName { get; set; }

    [StringLength(1000)]
    public string? ImporterIdentificationNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceAmount { get; set; }

    [StringLength(1000)]
    public string? InvoiceCurrencyCode { get; set; }

    public DateTime? InvoiceIssueDate { get; set; }

    [StringLength(1000)]
    public string? InvoiceNumber { get; set; }

    public DateTime? IssueDate { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidNcyFobAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidNcyFreightAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidNcyInsuranceAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidNcyOtherChargesAmount { get; set; }

    [Range(-999999999, 999999999)]
    public double? LiquidNcyTotalTaxableBaseAmount { get; set; }

    [StringLength(1000)]
    public string? PackageUnitCode { get; set; }

    [StringLength(1000)]
    public string? RecipientCountryCode { get; set; }

    [StringLength(1000)]
    public string? ReportNumber { get; set; }

    [StringLength(1000)]
    public string? RvcNumber { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalGrossWeight { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalNetWeight { get; set; }

    [Range(-999999999, 999999999)]
    public int? TotalNumberOfPackages { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

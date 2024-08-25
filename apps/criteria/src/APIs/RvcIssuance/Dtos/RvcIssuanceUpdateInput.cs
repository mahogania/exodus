namespace Criteria.APIs.Dtos;

public class RvcIssuanceUpdateInput
{
    public string? AttachmentFileId { get; set; }

    public string? BlNumber { get; set; }

    public DateTime? CreatedAt { get; set; }

    public double? DeclaredNcyFobAmount { get; set; }

    public double? DeclaredNcyFreightAmount { get; set; }

    public double? DeclaredNcyInsuranceAmount { get; set; }

    public double? DeclaredNcyOtherChargesAmount { get; set; }

    public double? DeclaredNcyTotalTaxableBaseAmount { get; set; }

    public string? DeliveryConditionCode { get; set; }

    public string? ExporterAddress { get; set; }

    public string? ExporterCompanyName { get; set; }

    public string? ExporterCountryCode { get; set; }

    public string? ExporterIdentificationNumber { get; set; }

    public string? Id { get; set; }

    public string? ImporterAddress { get; set; }

    public string? ImporterCompanyName { get; set; }

    public string? ImporterIdentificationNumber { get; set; }

    public double? InvoiceAmount { get; set; }

    public string? InvoiceCurrencyCode { get; set; }

    public DateTime? InvoiceIssueDate { get; set; }

    public string? InvoiceNumber { get; set; }

    public DateTime? IssueDate { get; set; }

    public double? LiquidNcyFobAmount { get; set; }

    public double? LiquidNcyFreightAmount { get; set; }

    public double? LiquidNcyInsuranceAmount { get; set; }

    public double? LiquidNcyOtherChargesAmount { get; set; }

    public double? LiquidNcyTotalTaxableBaseAmount { get; set; }

    public string? PackageUnitCode { get; set; }

    public string? RecipientCountryCode { get; set; }

    public string? ReportNumber { get; set; }

    public string? RvcNumber { get; set; }

    public double? TotalGrossWeight { get; set; }

    public double? TotalNetWeight { get; set; }

    public int? TotalNumberOfPackages { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

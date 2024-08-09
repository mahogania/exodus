using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Accountings")]
public class AccountingDbModel
{
    [StringLength(1000)]
    public string? ApprovalId { get; set; }

    [StringLength(1000)]
    public string? AttachmentId { get; set; }

    [StringLength(1000)]
    public string? ContainerSize { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Crn { get; set; }

    [StringLength(1000)]
    public string? CustomsAreaCode { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FinalUseCode { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? HandlingDate { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ItemName { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfPackages { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceFileRegistrationDate { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeName { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [StringLength(1000)]
    public string? StockAccountingManagementNumber { get; set; }

    [StringLength(1000)]
    public string? Storage { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? Weight { get; set; }
}

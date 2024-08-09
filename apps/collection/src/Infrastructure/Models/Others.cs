using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Others")]
public class OthersDbModel
{
    [Range(-999999999, 999999999)]
    public double? AmountOfOtherChargeableFees { get; set; }

    [StringLength(1000)]
    public string? AttachmentId { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FinancialManagerName { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? NiuCategoryCode { get; set; }

    [StringLength(1000)]
    public string? NiuCategoryName { get; set; }

    [StringLength(1000)]
    public string? NoticeNo { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumberTypeName { get; set; }

    [StringLength(1000)]
    public string? RegistrationReasonContent { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [StringLength(1000)]
    public string? TaxpayerIdentificationNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

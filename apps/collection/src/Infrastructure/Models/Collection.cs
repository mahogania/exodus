using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Collections")]
public class CollectionDbModel
{
    [StringLength(1000)]
    public string? AttachmentFileId { get; set; }

    [Range(-999999999, 999999999)]
    public double? CollectedAmount { get; set; }

    [StringLength(1000)]
    public string? CollectionBankCode { get; set; }

    [StringLength(1000)]
    public string? CollectionNo { get; set; }

    [StringLength(1000)]
    public string? CollectionTypeCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? ExpenseCertificateNo { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ManualRegistrationReasonContent { get; set; }

    [StringLength(1000)]
    public string? NoticeNo { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? PaymentDate { get; set; }

    [StringLength(1000)]
    public string? RegisteringPersonId { get; set; }

    [StringLength(1000)]
    public string? RegistrationDate { get; set; }

    [StringLength(1000)]
    public string? RegistrationSystemCategoryCode { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [StringLength(1000)]
    public string? TaxpayerPhoneNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

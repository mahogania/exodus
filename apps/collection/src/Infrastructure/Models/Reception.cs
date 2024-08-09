using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("Receptions")]
public class ReceptionDbModel
{
    [StringLength(1000)]
    public string? AuthorizationCode { get; set; }

    [StringLength(1000)]
    public string? CardNo { get; set; }

    [StringLength(1000)]
    public string? CardValidityDuration { get; set; }

    [StringLength(1000)]
    public string? CardholderName { get; set; }

    [StringLength(1000)]
    public string? CollectionNo { get; set; }

    [StringLength(1000)]
    public string? ConnectionIp { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? ErrorMessageContent { get; set; }

    [StringLength(1000)]
    public string? ErrorsErrorCode { get; set; }

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
    public string? LinkingParameterContent { get; set; }

    [StringLength(1000)]
    public string? NoticeNo { get; set; }

    [StringLength(1000)]
    public string? OrderIdentifier { get; set; }

    [StringLength(1000)]
    public string? OrderNumber { get; set; }

    [StringLength(1000)]
    public string? OrderStatusParameter { get; set; }

    public DateTime? PaymentDateAndTime { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusCode { get; set; }

    [StringLength(1000)]
    public string? ProcessingStatusContent { get; set; }

    [StringLength(1000)]
    public string? ThreeDigitCountryCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalNoticeAmount { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

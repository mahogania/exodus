using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collection.Infrastructure.Models;

[Table("NoticeTypes")]
public class NoticeTypeDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? LatePaymentInterestAmountCapRate { get; set; }

    [Range(-999999999, 999999999)]
    public double? LatePaymentInterestRate { get; set; }

    [StringLength(1000)]
    public string? NoticeTypeCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfDueDays { get; set; }

    [Range(-999999999, 999999999)]
    public double? NumberOfTimesUsed { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? UsedOn { get; set; }
}

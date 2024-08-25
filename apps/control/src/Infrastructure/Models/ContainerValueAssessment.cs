using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ContainerValueAssessments")]
public class ContainerValueAssessmentDbModel
{
    public string? CommonVerificationId { get; set; }

    [ForeignKey(nameof(CommonVerificationId))]
    public CommonVerificationDbModel? CommonVerification { get; set; } = null;

    [StringLength(1000)]
    public string? ContainerNumber { get; set; }

    [StringLength(1000)]
    public string? ContainerSequenceNumber { get; set; }

    [StringLength(1000)]
    public string? ContainerStuffingStateCode { get; set; }

    [StringLength(1000)]
    public string? ContainerTypeCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public DateTime? DeletedOn { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InitialRecorderId { get; set; }

    [StringLength(1000)]
    public string? SealNumber1 { get; set; }

    [StringLength(1000)]
    public string? SealNumber2_24310 { get; set; }

    [StringLength(1000)]
    public string? SealNumber3 { get; set; }

    [StringLength(1000)]
    public string? SealingPersonCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

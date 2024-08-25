using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("VerificationResults")]
public class VerificationResultDbModel
{
    public string? CommonVerificationId { get; set; }

    [ForeignKey(nameof(CommonVerificationId))]
    public CommonVerificationDbModel? CommonVerification { get; set; } = null;

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
    public string? InspectorId { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    public DateTime? VerificationCompletedOn { get; set; }

    [StringLength(1000)]
    public string? VerificationResultContent { get; set; }

    public List<VerificationResultDetailDbModel>? VerificationResultDetails { get; set; } =
        new List<VerificationResultDetailDbModel>();

    public DateTime? VerificationResultRecordDate { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("VerificationResultDetails")]
public class VerificationResultDetailDbModel
{
    [StringLength(1000)]
    public string? AlignmentOrder { get; set; }

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

    [Required()]
    public DateTime UpdatedAt { get; set; }

    public string? VerificationResultId { get; set; }

    [ForeignKey(nameof(VerificationResultId))]
    public VerificationResultDbModel? VerificationResult { get; set; } = null;

    [StringLength(1000)]
    public string? VerificationResultCode { get; set; }
}

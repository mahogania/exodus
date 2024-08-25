using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("Appeals")]
public class AppealDbModel
{
    [StringLength(1000)]
    public string? AppealContent { get; set; }

    [StringLength(1000)]
    public string? AttachedFileId { get; set; }

    public List<CommonVerificationDbModel>? CommonVerifications { get; set; } =
        new List<CommonVerificationDbModel>();

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public bool? DeletedOn { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InitialRecorderId { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

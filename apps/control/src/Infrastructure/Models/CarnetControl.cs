using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Control.Core.Enums;

namespace Control.Infrastructure.Models;

[Table("CarnetControls")]
public class CarnetControlDbModel
{
    [StringLength(1000)]
    public string? AtaCarnetManagementNumber { get; set; }

    [StringLength(1000)]
    public string? AttachedFileId { get; set; }

    public DateTime? AuthorizationDate { get; set; }

    [StringLength(1000)]
    public string? CarnetTypeCode { get; set; }

    public string? CommonCarnetRequestId { get; set; }

    [ForeignKey(nameof(CommonCarnetRequestId))]
    public CommonCarnetRequestDbModel? CommonCarnetRequest { get; set; } = null;

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfInitialRecord { get; set; }

    public DateTime? DeletedOn { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    public DateTime? GrantedDeadlineEndDate { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InitialRecorderId { get; set; }

    public ProcessingStatusCodeEnum? ProcessingStatusCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? VerificationResultContent { get; set; }
}

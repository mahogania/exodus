using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ChangeInTheDetailedDeclarations")]
public class ChangeInTheDetailedDeclarationDbModel
{
    public string? CommonDetailedDeclarationId { get; set; }

    [ForeignKey(nameof(CommonDetailedDeclarationId))]
    public CommonDetailedDeclarationDbModel? CommonDetailedDeclaration { get; set; } = null;

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public DateTime? DateAndTimeOfTreatmentDecision { get; set; }

    public bool? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? ExecutionCodeByStatusTreatment { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrantId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? StatusTreatmentCode { get; set; }

    [StringLength(1000)]
    public string? TreatmentStatusContent { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

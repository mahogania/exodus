using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("TpdControls")]
public class TpdControlDbModel
{
    [StringLength(1000)]
    public string? ApprovalId { get; set; }

    [StringLength(1000)]
    public string? ApprovalProcessStatusCode { get; set; }

    public string? BaggageControlArticleId { get; set; }

    [ForeignKey(nameof(BaggageControlArticleId))]
    public BaggageControlArticleDbModel? BaggageControlArticle { get; set; } = null;

    [StringLength(1000)]
    public string? ControlResult { get; set; }

    public DateTime? ControlResultRegistrationDateTime { get; set; }

    [StringLength(1000)]
    public string? ControlStatus { get; set; }

    [StringLength(1000)]
    public string? ControlTypeCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeletionOn { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    public List<ImportDeclarationDbModel>? ImportDeclarations { get; set; } =
        new List<ImportDeclarationDbModel>();

    [StringLength(1000)]
    public string? InspectorId { get; set; }

    [Range(-999999999, 999999999)]
    public double? JudgmentOrder { get; set; }

    [StringLength(1000)]
    public string? TpdNumber { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? VerificationResultCode { get; set; }

    [StringLength(1000)]
    public string? VerificationResultContent { get; set; }
}

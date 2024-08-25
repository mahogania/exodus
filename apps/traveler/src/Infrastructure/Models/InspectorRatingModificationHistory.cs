using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("InspectorRatingModificationHistories")]
public class InspectorRatingModificationHistoryDbModel
{
    [StringLength(1000)]
    public string? AuditorClassificationCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DistributionContent { get; set; }

    [StringLength(1000)]
    public string? DistributionReasonCode { get; set; }

    [StringLength(1000)]
    public string? ExaminerIdAfterModification { get; set; }

    [StringLength(1000)]
    public string? ExaminerIdBeforeChange { get; set; }

    public DateTime? FinalModificationDateAndTime { get; set; }

    public DateTime? FirstRegistrationDateAndTime { get; set; }

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Range(-999999999, 999999999)]
    public double? HistorySequenceNumber { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ReferenceNumber { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

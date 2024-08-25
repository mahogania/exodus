using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("InspectorRatingCriteriaInspectors")]
public class InspectorRatingCriteriaInspectorDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public int? FieldSequenceNumber { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InspectorId { get; set; }

    public string? InspectorRatingCriteriaId { get; set; }

    [ForeignKey(nameof(InspectorRatingCriteriaId))]
    public InspectorRatingCriterionDbModel? InspectorRatingCriteria { get; set; } = null;

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

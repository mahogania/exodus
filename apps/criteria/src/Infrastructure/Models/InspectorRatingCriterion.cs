using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("InspectorRatingCriteria")]
public class InspectorRatingCriterionDbModel
{
    [Required()]
    [StringLength(1000)]
    public string AgencyCode { get; set; }

    [Range(0, 99999999999)]
    public int? ApplicationPriority { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? EndApcCode { get; set; }

    [StringLength(1000)]
    public string? EndFieldShCode { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public List<InspectorRatingCriteriaDeclarationModelDbModel>? InspectorRatingCriteriaDeclarationModel { get; set; } =
        new List<InspectorRatingCriteriaDeclarationModelDbModel>();

    public List<InspectorRatingCriteriaInspectorDbModel>? InspectorRatingCriteriaInspector { get; set; } =
        new List<InspectorRatingCriteriaInspectorDbModel>();

    [Required()]
    [StringLength(1000)]
    public string ServiceCode { get; set; }

    [StringLength(1000)]
    public string? StartApcCode { get; set; }

    [StringLength(1000)]
    public string? StartFieldShCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

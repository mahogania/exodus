namespace Criteria.APIs.Dtos;

public class InspectorRatingCriterion
{
    public string AgencyCode { get; set; }

    public int? ApplicationPriority { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? EndApcCode { get; set; }

    public string? EndFieldShCode { get; set; }

    public string Id { get; set; }

    public List<string>? InspectorRatingCriteriaDeclarationModel { get; set; }

    public List<string>? InspectorRatingCriteriaInspector { get; set; }

    public string ServiceCode { get; set; }

    public string? StartApcCode { get; set; }

    public string? StartFieldShCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}

namespace Criteria.APIs.Dtos;

public class InspectorRatingCriterionCreateInput
{
    public string AgencyCode { get; set; }

    public int? ApplicationPriority { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? EndApcCode { get; set; }

    public string? EndFieldShCode { get; set; }

    public string? Id { get; set; }

    public List<InspectorRatingCriteriaDeclarationModel>? InspectorRatingCriteriaDeclarationModel { get; set; }

    public List<InspectorRatingCriteriaInspector>? InspectorRatingCriteriaInspector { get; set; }

    public string ServiceCode { get; set; }

    public string? StartApcCode { get; set; }

    public string? StartFieldShCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}

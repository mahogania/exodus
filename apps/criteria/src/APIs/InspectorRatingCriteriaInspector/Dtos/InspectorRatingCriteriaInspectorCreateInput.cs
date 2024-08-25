namespace Criteria.APIs.Dtos;

public class InspectorRatingCriteriaInspectorCreateInput
{
    public DateTime CreatedAt { get; set; }

    public int? FieldSequenceNumber { get; set; }

    public string? Id { get; set; }

    public string? InspectorId { get; set; }

    public InspectorRatingCriterion? InspectorRatingCriteria { get; set; }

    public string? OfficeCode { get; set; }

    public string? ServiceCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}

namespace Criteria.APIs.Dtos;

public class InspectorRatingCriteriaDeclarationModel
{
    public DateTime CreatedAt { get; set; }

    public string? DeclarationTypeCode { get; set; }

    public int? FieldSequenceNumber { get; set; }

    public string Id { get; set; }

    public string? InspectorRatingCriteria { get; set; }

    public string? OfficeCode { get; set; }

    public string? ServiceCode { get; set; }

    public DateTime UpdatedAt { get; set; }
}

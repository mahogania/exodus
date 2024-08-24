namespace Control.APIs.Dtos;

public class ValueAssessmentCreateInput
{
    public List<ArticleAssessment>? Articles { get; set; }

    public CommonDetailedDeclaration? CommonDetailedDeclarations { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public DateTime UpdatedAt { get; set; }
}

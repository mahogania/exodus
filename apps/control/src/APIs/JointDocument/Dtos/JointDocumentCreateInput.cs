namespace Control.APIs.Dtos;

public class JointDocumentCreateInput
{
    public CommonDetailedDeclaration? CommonDetailedDeclaration { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public DateTime UpdatedAt { get; set; }
}

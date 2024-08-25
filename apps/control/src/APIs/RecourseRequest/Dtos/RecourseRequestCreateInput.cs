namespace Control.APIs.Dtos;

public class RecourseRequestCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public Procedure? Journal { get; set; }

    public DateTime UpdatedAt { get; set; }
}

namespace Control.APIs.Dtos;

public class RecourseRequestCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public Journal? Journal { get; set; }

    public DateTime UpdatedAt { get; set; }
}

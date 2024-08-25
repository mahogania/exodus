namespace Criteria.APIs.Dtos;

public class ClearanceFretContainerCreateInput
{
    public ClearanceFretInterface? ClearanceFretInterface { get; set; }

    public string ContainerId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public DateTime UpdatedAt { get; set; }
}

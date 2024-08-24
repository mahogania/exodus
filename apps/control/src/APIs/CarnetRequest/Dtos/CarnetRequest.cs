namespace Control.APIs.Dtos;

public class CarnetRequest
{
    public string? CarnetTypeCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Id { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public DateTime UpdatedAt { get; set; }
}

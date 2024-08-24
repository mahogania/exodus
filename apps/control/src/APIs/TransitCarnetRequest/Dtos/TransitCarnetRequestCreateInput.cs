namespace Control.APIs.Dtos;

public class TransitCarnetRequestCreateInput
{
    public CarnetRequest? CarnetRequest { get; set; }

    public string? CarnetTypeCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public string? ReferenceNo { get; set; }

    public TransitCarnetControl? TransitCarnetControl { get; set; }

    public DateTime UpdatedAt { get; set; }
}

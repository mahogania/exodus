namespace Control.APIs.Dtos;

public class TransitCarnetRequestUpdateInput
{
    public string? CarnetRequest { get; set; }

    public string? CarnetTypeCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public string? ReferenceNo { get; set; }

    public string? TransitCarnetControl { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

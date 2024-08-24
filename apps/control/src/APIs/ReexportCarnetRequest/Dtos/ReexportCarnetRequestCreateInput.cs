namespace Control.APIs.Dtos;

public class ReexportCarnetRequestCreateInput
{
    public string? CarnetNumber { get; set; }

    public string? CarnetTypeCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public ReexportCarnetControl? ReexportCarnetControl { get; set; }

    public string? ReferenceNo { get; set; }

    public DateTime UpdatedAt { get; set; }
}

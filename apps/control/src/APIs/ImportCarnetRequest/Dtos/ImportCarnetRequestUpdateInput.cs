namespace Control.APIs.Dtos;

public class ImportCarnetRequestUpdateInput
{
    public string? CarnetNumber { get; set; }

    public string? CarnetTypeCode { get; set; }

    public string? CommonCarnetRequest { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? ImportCarnetControl { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public string? ReferenceNo { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

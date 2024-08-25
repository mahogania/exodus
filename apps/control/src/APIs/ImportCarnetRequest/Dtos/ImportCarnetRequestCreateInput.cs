namespace Control.APIs.Dtos;

public class ImportCarnetRequestCreateInput
{
    public string? CarnetNumber { get; set; }

    public string? CarnetTypeCode { get; set; }

    public CommonCarnetRequest? CommonCarnetRequest { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public ImportCarnetControl? ImportCarnetControl { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public string? ReferenceNo { get; set; }

    public DateTime UpdatedAt { get; set; }
}

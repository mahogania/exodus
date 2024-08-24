namespace Control.APIs.Dtos;

public class ExtendedPeriodCarnetRequestCreateInput
{
    public string? CarnetTypeCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public ExtendedPeriodCarnetControl? ExtendedPeriodCarnetControl { get; set; }

    public string? Id { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public string? SequenceNumber { get; set; }

    public DateTime UpdatedAt { get; set; }
}

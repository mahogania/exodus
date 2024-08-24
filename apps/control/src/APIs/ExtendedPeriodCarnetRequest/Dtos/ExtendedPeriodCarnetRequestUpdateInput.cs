namespace Control.APIs.Dtos;

public class ExtendedPeriodCarnetRequestUpdateInput
{
    public string? CarnetRequest { get; set; }

    public string? CarnetTypeCode { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? ExtendedPeriodCarnetControl { get; set; }

    public string? Id { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public string? SequenceNumber { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

namespace Control.APIs.Dtos;

public class CarnetRequestUpdateInput
{
    public List<string>? ArticleCarnetRequests { get; set; }

    public string? CarnetTypeCode { get; set; }

    public string? CommonCarnetRequest { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? ExtendedPeriodCarnetRequests { get; set; }

    public string? Id { get; set; }

    public List<string>? ImportCarnetRequests { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public List<string>? ReexportCarnetRequests { get; set; }

    public List<string>? TransitCarnetRequests { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

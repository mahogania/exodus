namespace Control.APIs.Dtos;

public class CarnetRequestCreateInput
{
    public List<ArticleCarnetRequest>? ArticleCarnetRequests { get; set; }

    public string? CarnetTypeCode { get; set; }

    public CommonCarnetRequest? CommonCarnetRequest { get; set; }

    public DateTime CreatedAt { get; set; }

    public ExtendedPeriodCarnetRequest? ExtendedPeriodCarnetRequests { get; set; }

    public string? Id { get; set; }

    public List<ImportCarnetRequest>? ImportCarnetRequests { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public List<ReexportCarnetRequest>? ReexportCarnetRequests { get; set; }

    public List<TransitCarnetRequest>? TransitCarnetRequests { get; set; }

    public DateTime UpdatedAt { get; set; }
}

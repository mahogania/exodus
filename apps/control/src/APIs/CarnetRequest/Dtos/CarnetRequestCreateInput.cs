namespace Control.APIs.Dtos;

public class CarnetRequestCreateInput
{
    public List<ArticleCarnetRequest>? ArticleCarnetRequests { get; set; }

    public string? CarnetTypeCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public DateTime UpdatedAt { get; set; }
}

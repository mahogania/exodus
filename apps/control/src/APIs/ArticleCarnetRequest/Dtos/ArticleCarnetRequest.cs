namespace Control.APIs.Dtos;

public class ArticleCarnetRequest
{
    public string? ArticleCarnetControl { get; set; }

    public string? ArticleNumber { get; set; }

    public string? CarnetNumber { get; set; }

    public string? CarnetTypeCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Id { get; set; }

    public string? ManagementNumberOfCarnet { get; set; }

    public string? OperationTypeCode { get; set; }

    public string? ReferenceNo { get; set; }

    public DateTime UpdatedAt { get; set; }
}

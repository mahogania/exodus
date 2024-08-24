using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ArticleCarnetRequests")]
public class ArticleCarnetRequestDbModel
{
    public string? ArticleCarnetControlId { get; set; }

    [ForeignKey(nameof(ArticleCarnetControlId))]
    public ArticleCarnetControlDbModel? ArticleCarnetControl { get; set; } = null;

    [StringLength(1000)]
    public string? ArticleNumber { get; set; }

    [StringLength(1000)]
    public string? CarnetNumber { get; set; }

    public string? CarnetRequestId { get; set; }

    [ForeignKey(nameof(CarnetRequestId))]
    public CarnetRequestDbModel? CarnetRequest { get; set; } = null;

    [StringLength(1000)]
    public string? CarnetTypeCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ManagementNumberOfCarnet { get; set; }

    [StringLength(1000)]
    public string? OperationTypeCode { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

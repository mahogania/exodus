using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("CarnetRequests")]
public class CarnetRequestDbModel
{
    public List<ArticleCarnetRequestDbModel>? ArticleCarnetRequests { get; set; } =
        new List<ArticleCarnetRequestDbModel>();

    [StringLength(1000)]
    public string? CarnetTypeCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ManagementNumberOfCarnet { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

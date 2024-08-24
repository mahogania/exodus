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

    public string? CommonCarnetRequestId { get; set; }

    [ForeignKey(nameof(CommonCarnetRequestId))]
    public CommonCarnetRequestDbModel? CommonCarnetRequest { get; set; } = null;

    [Required()]
    public DateTime CreatedAt { get; set; }

    public string? ExtendedPeriodCarnetRequestsId { get; set; }

    [ForeignKey(nameof(ExtendedPeriodCarnetRequestsId))]
    public ExtendedPeriodCarnetRequestDbModel? ExtendedPeriodCarnetRequests { get; set; } = null;

    [Key()]
    [Required()]
    public string Id { get; set; }

    public List<ImportCarnetRequestDbModel>? ImportCarnetRequests { get; set; } =
        new List<ImportCarnetRequestDbModel>();

    [StringLength(1000)]
    public string? ManagementNumberOfCarnet { get; set; }

    public List<ReexportCarnetRequestDbModel>? ReexportCarnetRequests { get; set; } =
        new List<ReexportCarnetRequestDbModel>();

    public List<TransitCarnetRequestDbModel>? TransitCarnetRequests { get; set; } =
        new List<TransitCarnetRequestDbModel>();

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

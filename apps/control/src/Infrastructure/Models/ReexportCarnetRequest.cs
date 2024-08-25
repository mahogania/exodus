using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ReexportCarnetRequests")]
public class ReexportCarnetRequestDbModel
{
    [StringLength(1000)]
    public string? CarnetNumber { get; set; }

    [StringLength(1000)]
    public string? CarnetTypeCode { get; set; }

    public string? CommonCarnetRequestId { get; set; }

    [ForeignKey(nameof(CommonCarnetRequestId))]
    public CommonCarnetRequestDbModel? CommonCarnetRequest { get; set; } = null;

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ManagementNumberOfCarnet { get; set; }

    public ReexportCarnetControlDbModel? ReexportCarnetControl { get; set; } = null;

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

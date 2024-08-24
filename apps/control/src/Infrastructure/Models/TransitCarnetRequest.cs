using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("TransitCarnetRequests")]
public class TransitCarnetRequestDbModel
{
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

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    public string? TransitCarnetControlId { get; set; }

    [ForeignKey(nameof(TransitCarnetControlId))]
    public TransitCarnetControlDbModel? TransitCarnetControl { get; set; } = null;

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

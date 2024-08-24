using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ExtendedPeriodCarnetRequests")]
public class ExtendedPeriodCarnetRequestDbModel
{
    [StringLength(1000)]
    public string? CarnetTypeCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public ExtendedPeriodCarnetControlDbModel? ExtendedPeriodCarnetControl { get; set; } = null;

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? ManagementNumberOfCarnet { get; set; }

    [StringLength(1000)]
    public string? SequenceNumber { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

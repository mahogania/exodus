using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ImportCarnetRequests")]
public class ImportCarnetRequestDbModel
{
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

    public string? ImportCarnetControlId { get; set; }

    [ForeignKey(nameof(ImportCarnetControlId))]
    public ImportCarnetControlDbModel? ImportCarnetControl { get; set; } = null;

    [StringLength(1000)]
    public string? ManagementNumberOfCarnet { get; set; }

    [StringLength(1000)]
    public string? ReferenceNo { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

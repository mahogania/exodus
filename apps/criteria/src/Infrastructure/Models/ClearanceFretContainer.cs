using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("ClearanceFretContainers")]
public class ClearanceFretContainerDbModel
{
    public string? ClearanceFretInterfaceId { get; set; }

    [ForeignKey(nameof(ClearanceFretInterfaceId))]
    public ClearanceFretInterfaceDbModel? ClearanceFretInterface { get; set; } = null;

    [Required()]
    [StringLength(1000)]
    public string ContainerId { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

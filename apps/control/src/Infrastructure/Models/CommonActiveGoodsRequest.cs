using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("CommonActiveGoodsRequests")]
public class CommonActiveGoodsRequestDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public List<DetailOfActiveGoodsDbModel>? Details { get; set; } =
        new List<DetailOfActiveGoodsDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    public string? JournalId { get; set; }

    [ForeignKey(nameof(JournalId))]
    public JournalDbModel? Journal { get; set; } = null;

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

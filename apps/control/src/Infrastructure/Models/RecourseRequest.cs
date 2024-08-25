using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("RecourseRequests")]
public class RecourseRequestDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public string? JournalId { get; set; }

    [ForeignKey(nameof(JournalId))]
    public ProcedureDbModel? Journal { get; set; } = null;

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

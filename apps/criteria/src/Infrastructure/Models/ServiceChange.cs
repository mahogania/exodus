using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("ServiceChanges")]
public class ServiceChangeDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DetailedDeclarationNumber { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? InitialServiceCode { get; set; }

    public DateTime? ModificationDate { get; set; }

    [Range(-999999999, 999999999)]
    public int? ModificationNumber { get; set; }

    [StringLength(1000)]
    public string? ModificationResponsibleId { get; set; }

    [StringLength(1000)]
    public string? NewServiceCode { get; set; }

    [StringLength(1000)]
    public string? ReasonForModification { get; set; }

    [StringLength(1000)]
    public string? ServiceChangeReasonCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

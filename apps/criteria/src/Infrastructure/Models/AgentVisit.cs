using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("AgentVisits")]
public class AgentVisitDbModel
{
    [Required()]
    [StringLength(1000)]
    public string AgencyCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    [StringLength(1000)]
    public string ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Required()]
    public DateTime VerificationDate { get; set; }

    [StringLength(1000)]
    public string? VerifierId { get; set; }
}

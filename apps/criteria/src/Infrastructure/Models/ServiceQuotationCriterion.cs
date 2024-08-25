using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("ServiceQuotationCriteria")]
public class ServiceQuotationCriterionDbModel
{
    [Required()]
    [StringLength(1000)]
    public string AgencyCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? CriterionContent { get; set; }

    public DateTime? EndApplicationDate { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public DateTime? StartApplicationDate { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

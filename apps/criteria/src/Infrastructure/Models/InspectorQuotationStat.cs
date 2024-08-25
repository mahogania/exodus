using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("InspectorQuotationStats")]
public class InspectorQuotationStatDbModel
{
    [Range(0, 99999999999)]
    public int? AffectationNumber { get; set; }

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
    public string InspectorId { get; set; }

    [Required()]
    public DateTime QuotationDate { get; set; }

    [Required()]
    [StringLength(1000)]
    public string ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

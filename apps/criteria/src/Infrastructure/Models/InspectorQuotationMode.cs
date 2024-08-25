using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("InspectorQuotationModes")]
public class InspectorQuotationModeDbModel
{
    [Required()]
    [StringLength(1000)]
    public string AgencyCode { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [Required()]
    [StringLength(1000)]
    public string DeclarationTypeCode { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? QuotationModeType { get; set; }

    [Required()]
    [StringLength(1000)]
    public string ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

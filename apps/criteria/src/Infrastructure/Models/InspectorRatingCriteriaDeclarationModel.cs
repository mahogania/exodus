using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("InspectorRatingCriteriaDeclarationModels")]
public class InspectorRatingCriteriaDeclarationModelDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DeclarationTypeCode { get; set; }

    [Range(-999999999, 999999999)]
    public int? FieldSequenceNumber { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? OfficeCode { get; set; }

    [StringLength(1000)]
    public string? ServiceCode { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

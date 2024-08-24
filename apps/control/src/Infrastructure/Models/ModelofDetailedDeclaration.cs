using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Control.Infrastructure.Models;

[Table("ModelofDetailedDeclarations")]
public class ModelofDetailedDeclarationDbModel
{
    public string? ArticleId { get; set; }

    [ForeignKey(nameof(ArticleId))]
    public ArticleDbModel? Article { get; set; } = null;

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateAndTimeOfFinalModification { get; set; }

    public DateTime? DateAndTimeOfFirstRegistration { get; set; }

    public DateTime? DeletionOn { get; set; }

    [StringLength(1000)]
    public string? FinalModifierId { get; set; }

    [StringLength(1000)]
    public string? FirstRegistrarId { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public double? InvoiceAmount { get; set; }

    [StringLength(1000)]
    public string? ModelAndSpecificationNameComponent { get; set; }

    [Range(-999999999, 999999999)]
    public int? Quantity { get; set; }

    [StringLength(1000)]
    public string? UnitOfQuantityCode { get; set; }

    [Range(-999999999, 999999999)]
    public double? UnitPrice { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

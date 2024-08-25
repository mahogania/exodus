using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("ShAnalyseCollectionTemporaire2s")]
public class ShAnalyseCollectionTemporaire2DbModel
{
    [Range(-999999999, 999999999)]
    public int? ClassementGroupesPrixNcyUnitaires { get; set; }

    [Range(-999999999, 999999999)]
    public int? ClassementGroupesPrixUsdUnitaires { get; set; }

    [StringLength(1000)]
    public string? CodeSh { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public int? ModificateurFinalId { get; set; }

    [Range(-999999999, 999999999)]
    public int? PremierEnregistrantId { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixNcyUnitaire { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUsdUnitaire { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

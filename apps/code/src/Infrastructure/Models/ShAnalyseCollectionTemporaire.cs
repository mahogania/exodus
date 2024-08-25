using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("ShAnalyseCollectionTemporaires")]
public class ShAnalyseCollectionTemporaireDbModel
{
    [Range(-999999999, 999999999)]
    public int? ClassementGroupesPrixNcyUnitaires { get; set; }

    [Range(-999999999, 999999999)]
    public int? ClassementGroupesPrixUsdUnitaires { get; set; }

    [Range(-999999999, 999999999)]
    public int? ClassementPrixNcyUnitaires { get; set; }

    [Range(-999999999, 999999999)]
    public int? ClassementPrixUsdUnitaires { get; set; }

    [StringLength(1000)]
    public string? CodePaysOrigine { get; set; }

    [StringLength(1000)]
    public string? CodeSh { get; set; }

    [StringLength(1000)]
    public string? CodeUniteQuantite { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public DateTime? DateValidation { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public int? ModificateurFinalId { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantNcyFacture { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantUsdFacture { get; set; }

    [StringLength(1000)]
    public string? NomMarque { get; set; }

    [StringLength(1000)]
    public string? NumeroArticle { get; set; }

    [StringLength(1000)]
    public string? NumeroDeclarationDetail { get; set; }

    [StringLength(1000)]
    public string? NumeroIdentificationExportateur { get; set; }

    [StringLength(1000)]
    public string? NumeroIdentificationImportateur { get; set; }

    [Range(-999999999, 999999999)]
    public int? PoidsParUnite { get; set; }

    [Range(-999999999, 999999999)]
    public int? PremierEnregistrantId { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixNcyUnitaire { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUsdUnitaire { get; set; }

    [Range(-999999999, 999999999)]
    public int? Quantite { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("PrixUnitaireDeclarationDetails")]
public class PrixUnitaireDeclarationDetailDbModel
{
    [StringLength(1000)]
    public string? CodeDevise { get; set; }

    [StringLength(1000)]
    public string? CodeMethodeEvaluationValeur { get; set; }

    [StringLength(1000)]
    public string? CodePaysExpedition { get; set; }

    [StringLength(1000)]
    public string? CodePaysOrigine { get; set; }

    [StringLength(1000)]
    public string? CodeProduitNeufEtUsage { get; set; }

    [StringLength(1000)]
    public string? CodeShDeclare { get; set; }

    [StringLength(1000)]
    public string? CodeShLiquide { get; set; }

    [StringLength(1000)]
    public string? CodeUniteQuantite { get; set; }

    [StringLength(1000)]
    public string? ContenuEvaluationValeur { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateDemande { get; set; }

    public DateTime? DateEvaluationValeur { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public DateTime? DateValidation { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public int? ModificateurFinalId { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantDeclareFacture { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantDeclareNcyFacture { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantNcyLiquideFacture { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantUsdLiquideFacture { get; set; }

    [StringLength(1000)]
    public string? NomArticle { get; set; }

    [StringLength(1000)]
    public string? NomComposant { get; set; }

    [StringLength(1000)]
    public string? NomEntrepriseExportateur { get; set; }

    [StringLength(1000)]
    public string? NomEntrepriseImportateur { get; set; }

    [StringLength(1000)]
    public string? NomMarque { get; set; }

    [StringLength(1000)]
    public string? NomModeleSpecification { get; set; }

    [StringLength(1000)]
    public string? NumeroArticle { get; set; }

    [StringLength(1000)]
    public string? NumeroDeclarationDetail { get; set; }

    [StringLength(1000)]
    public string? NumeroIdentificationExportateur { get; set; }

    [StringLength(1000)]
    public string? NumeroIdentificationImportateur { get; set; }

    [StringLength(1000)]
    public string? NumeroModeleSpecification { get; set; }

    [Range(-999999999, 999999999)]
    public int? PoidsNet { get; set; }

    [Range(-999999999, 999999999)]
    public int? PremierEnregistrantId { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixNcyUnitaireDeclare { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireNcyLiquide { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireUsdLiquide { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUsdUnitaireDeclare { get; set; }

    [Range(-999999999, 999999999)]
    public int? Quantite { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

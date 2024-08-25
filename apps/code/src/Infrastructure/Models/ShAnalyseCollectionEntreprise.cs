using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("ShAnalyseCollectionEntreprises")]
public class ShAnalyseCollectionEntrepriseDbModel
{
    [Range(-999999999, 999999999)]
    public int? AnneeAddition { get; set; }

    [StringLength(1000)]
    public string? CodeChampPeriodeAddition { get; set; }

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
    public int? MoisAddition { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantNcyFacture { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantNcyUniteMaximale { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantNcyUniteMinimale { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantUsdFacture { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantUsdUniteMaximale { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantUsdUniteMinimale { get; set; }

    [Range(-999999999, 999999999)]
    public int? NombreCasArticles { get; set; }

    [Range(-999999999, 999999999)]
    public int? NombreDeclarations { get; set; }

    [Range(-999999999, 999999999)]
    public int? PremierEnregistrantId { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireNcyEcartType { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireNcyLiquide { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireUsdEcartType { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireUsdLiquide { get; set; }

    [StringLength(1000)]
    public string? RegistreCommerce { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

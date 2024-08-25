using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("ShAnalyseEvolutionPrixCollections")]
public class ShAnalyseEvolutionPrixCollectionDbModel
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
    public int? MontantNcyFactureDernierePeriodeAddition { get; set; }

    [Range(-999999999, 999999999)]
    public int? MontantNcyFactureMoisAddition { get; set; }

    [Range(-999999999, 999999999)]
    public int? NombreDeclarationsDernierePeriodeAddition { get; set; }

    [Range(-999999999, 999999999)]
    public int? NombreDeclarationsMoisAddition { get; set; }

    [Range(-999999999, 999999999)]
    public int? PremierEnregistrantId { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Range(-999999999, 999999999)]
    public int? TauxAugmentationMontantFacture { get; set; }

    [Range(-999999999, 999999999)]
    public int? TauxAugmentationNombreDeclarations { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

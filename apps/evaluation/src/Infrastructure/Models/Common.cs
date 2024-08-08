using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluation.Infrastructure.Models;

[Table("Commons")]
public class CommonDbModel
{
    [StringLength(1000)]
    public string? CodeDeDeviseDAssurance { get; set; }

    [StringLength(1000)]
    public string? CodeDeDeviseDeLaDDuction { get; set; }

    [StringLength(1000)]
    public string? CodeDeDeviseDeLaFacture { get; set; }

    [StringLength(1000)]
    public string? CodeDeDeviseDesAutresCoTs { get; set; }

    [StringLength(1000)]
    public string? CodeDeDeviseDuFret { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    [StringLength(1000)]
    public string? FrQuenceDeRectification { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdDuModificateurFinal { get; set; }

    [StringLength(1000)]
    public string? IdDuPremierEnregistrant { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDAssurance { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDDuit { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDeFacture { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDesAutresCoTs { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDesAutresCoTsDeNcy { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDuFret { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyDDuit { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyDeFacture { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyDuFret { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyTotalDeLValuationDeValeur { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyTotalDeLaBaseTaxable { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNycDeLAssurance { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantUsdDeFacture { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantUsdTotalDeLValuationDeValeur { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantUsdTotalDeLaBaseTaxable { get; set; }

    [StringLength(1000)]
    public string? NDeRfRence { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeChangeDAssurance { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeChangeDeLaDDuction { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeChangeDeLaFacture { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeChangeDesAutresCoTs { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeChangeDuFret { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeRemise { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

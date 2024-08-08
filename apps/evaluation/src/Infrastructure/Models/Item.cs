using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluation.Infrastructure.Models;

[Table("Items")]
public class ItemDbModel
{
    [StringLength(1000)]
    public string? CodeDeDeviseDDuitDeLArticle { get; set; }

    [StringLength(1000)]
    public string? CodeDeDeviseDeLAssuranceDeLArticle { get; set; }

    [StringLength(1000)]
    public string? CodeDeDeviseDeLaFactureDeLArticle { get; set; }

    [StringLength(1000)]
    public string? CodeDeDeviseDeLaValeurMercurialeDeLArticle { get; set; }

    [StringLength(1000)]
    public string? CodeDeDeviseDesAutresFraisDeLArticle { get; set; }

    [StringLength(1000)]
    public string? CodeDeDeviseDuFretDeLArticle { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDeLaValeurMercurialeDeLArticle { get; set; }

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
    public double? MontantDDuitDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDeLAssuranceDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDeLaFactureDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDesAutresFraisDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDuFretDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyDDuitDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyDeLAssuranceDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyDeLValuationDeValeurDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyDeLaFactureDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyDeLaValeurBoursiReDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyDesAutresFraisDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNcyDuFretDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantNycDeLaBaseTaxableDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantUnitaireDeLaValeurBoursiReDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantUsdDeLValuationDeValeurDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantUsdDeLaBaseTaxableDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantUsdDeLaFactureDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantUsdDeLaValeurBoursiReDeLArticle { get; set; }

    [StringLength(1000)]
    public string? NDArticle { get; set; }

    [StringLength(1000)]
    public string? NDeRfRence { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeChangeDeLAssuranceDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeChangeDeLaDDuctionDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeChangeDeLaFactureDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeChangeDesAutresFraisDeLArticle { get; set; }

    [Range(-999999999, 999999999)]
    public double? TauxDeChangeDuFretDeLArticle { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? ValeurBasiqueDeLaValeurBoursiReDeLArticle { get; set; }
}

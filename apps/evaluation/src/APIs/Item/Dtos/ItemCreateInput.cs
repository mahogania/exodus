namespace Evaluation.APIs.Dtos;

public class ItemCreateInput
{
    public string? CodeDeDeviseDDuitDeLArticle { get; set; }

    public string? CodeDeDeviseDeLAssuranceDeLArticle { get; set; }

    public string? CodeDeDeviseDeLaFactureDeLArticle { get; set; }

    public string? CodeDeDeviseDeLaValeurMercurialeDeLArticle { get; set; }

    public string? CodeDeDeviseDesAutresFraisDeLArticle { get; set; }

    public string? CodeDeDeviseDuFretDeLArticle { get; set; }

    public string? CodeDeTypeDeLaValeurMercurialeDeLArticle { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public string? FrQuenceDeRectification { get; set; }

    public string? Id { get; set; }

    public string? IdDuModificateurFinal { get; set; }

    public string? IdDuPremierEnregistrant { get; set; }

    public double? MontantDDuitDeLArticle { get; set; }

    public double? MontantDeLAssuranceDeLArticle { get; set; }

    public double? MontantDeLaFactureDeLArticle { get; set; }

    public double? MontantDesAutresFraisDeLArticle { get; set; }

    public double? MontantDuFretDeLArticle { get; set; }

    public double? MontantNcyDDuitDeLArticle { get; set; }

    public double? MontantNcyDeLAssuranceDeLArticle { get; set; }

    public double? MontantNcyDeLValuationDeValeurDeLArticle { get; set; }

    public double? MontantNcyDeLaFactureDeLArticle { get; set; }

    public double? MontantNcyDeLaValeurBoursiReDeLArticle { get; set; }

    public double? MontantNcyDesAutresFraisDeLArticle { get; set; }

    public double? MontantNcyDuFretDeLArticle { get; set; }

    public double? MontantNycDeLaBaseTaxableDeLArticle { get; set; }

    public double? MontantUnitaireDeLaValeurBoursiReDeLArticle { get; set; }

    public double? MontantUsdDeLValuationDeValeurDeLArticle { get; set; }

    public double? MontantUsdDeLaBaseTaxableDeLArticle { get; set; }

    public double? MontantUsdDeLaFactureDeLArticle { get; set; }

    public double? MontantUsdDeLaValeurBoursiReDeLArticle { get; set; }

    public string? NDArticle { get; set; }

    public string? NDeRfRence { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public double? TauxDeChangeDeLAssuranceDeLArticle { get; set; }

    public double? TauxDeChangeDeLaDDuctionDeLArticle { get; set; }

    public double? TauxDeChangeDeLaFactureDeLArticle { get; set; }

    public double? TauxDeChangeDesAutresFraisDeLArticle { get; set; }

    public double? TauxDeChangeDuFretDeLArticle { get; set; }

    public DateTime UpdatedAt { get; set; }

    public double? ValeurBasiqueDeLaValeurBoursiReDeLArticle { get; set; }
}

namespace Evaluation.APIs.Dtos;

public class CommonUpdateInput
{
    public string? CodeDeDeviseDAssurance { get; set; }

    public string? CodeDeDeviseDeLaDDuction { get; set; }

    public string? CodeDeDeviseDeLaFacture { get; set; }

    public string? CodeDeDeviseDesAutresCoTs { get; set; }

    public string? CodeDeDeviseDuFret { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public string? FrQuenceDeRectification { get; set; }

    public string? Id { get; set; }

    public string? IdDuModificateurFinal { get; set; }

    public string? IdDuPremierEnregistrant { get; set; }

    public double? MontantDAssurance { get; set; }

    public double? MontantDDuit { get; set; }

    public double? MontantDeFacture { get; set; }

    public double? MontantDesAutresCoTs { get; set; }

    public double? MontantDesAutresCoTsDeNcy { get; set; }

    public double? MontantDuFret { get; set; }

    public double? MontantNcyDDuit { get; set; }

    public double? MontantNcyDeFacture { get; set; }

    public double? MontantNcyDuFret { get; set; }

    public double? MontantNcyTotalDeLValuationDeValeur { get; set; }

    public double? MontantNcyTotalDeLaBaseTaxable { get; set; }

    public double? MontantNycDeLAssurance { get; set; }

    public double? MontantUsdDeFacture { get; set; }

    public double? MontantUsdTotalDeLValuationDeValeur { get; set; }

    public double? MontantUsdTotalDeLaBaseTaxable { get; set; }

    public string? NDeRfRence { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public double? TauxDeChangeDAssurance { get; set; }

    public double? TauxDeChangeDeLaDDuction { get; set; }

    public double? TauxDeChangeDeLaFacture { get; set; }

    public double? TauxDeChangeDesAutresCoTs { get; set; }

    public double? TauxDeChangeDuFret { get; set; }

    public double? TauxDeRemise { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

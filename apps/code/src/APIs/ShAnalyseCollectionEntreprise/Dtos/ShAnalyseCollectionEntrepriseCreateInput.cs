namespace Code.APIs.Dtos;

public class ShAnalyseCollectionEntrepriseCreateInput
{
    public int? AnneeAddition { get; set; }

    public string? CodeChampPeriodeAddition { get; set; }

    public string? CodeSh { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public string? Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? MoisAddition { get; set; }

    public int? MontantNcyFacture { get; set; }

    public int? MontantNcyUniteMaximale { get; set; }

    public int? MontantNcyUniteMinimale { get; set; }

    public int? MontantUsdFacture { get; set; }

    public int? MontantUsdUniteMaximale { get; set; }

    public int? MontantUsdUniteMinimale { get; set; }

    public int? NombreCasArticles { get; set; }

    public int? NombreDeclarations { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public int? PrixUnitaireNcyEcartType { get; set; }

    public int? PrixUnitaireNcyLiquide { get; set; }

    public int? PrixUnitaireUsdEcartType { get; set; }

    public int? PrixUnitaireUsdLiquide { get; set; }

    public string? RegistreCommerce { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }
}

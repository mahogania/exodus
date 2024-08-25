namespace Code.APIs.Dtos;

public class ShAnalysePrixUnitaireUpdateInput
{
    public string? CodePaysOrigine { get; set; }

    public string? CodeSh { get; set; }

    public string? CodeUniteQuantite { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public DateTime? DateValidation { get; set; }

    public string? Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? MontantNcyFacture { get; set; }

    public int? MontantUsdFacture { get; set; }

    public string? NomMarque { get; set; }

    public string? NumeroArticle { get; set; }

    public string? NumeroDeclarationDetail { get; set; }

    public string? NumeroIdentificationExportateur { get; set; }

    public string? NumeroIdentificationImportateur { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public int? PrixNcyUnitaire { get; set; }

    public int? PrixUsdUnitaire { get; set; }

    public int? Quantite { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

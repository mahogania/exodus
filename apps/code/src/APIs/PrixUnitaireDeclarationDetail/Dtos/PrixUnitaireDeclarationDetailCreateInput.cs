namespace Code.APIs.Dtos;

public class PrixUnitaireDeclarationDetailCreateInput
{
    public string? CodeDevise { get; set; }

    public string? CodeMethodeEvaluationValeur { get; set; }

    public string? CodePaysExpedition { get; set; }

    public string? CodePaysOrigine { get; set; }

    public string? CodeProduitNeufEtUsage { get; set; }

    public string? CodeShDeclare { get; set; }

    public string? CodeShLiquide { get; set; }

    public string? CodeUniteQuantite { get; set; }

    public string? ContenuEvaluationValeur { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateDemande { get; set; }

    public DateTime? DateEvaluationValeur { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public DateTime? DateValidation { get; set; }

    public string? Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? MontantDeclareFacture { get; set; }

    public int? MontantDeclareNcyFacture { get; set; }

    public int? MontantNcyLiquideFacture { get; set; }

    public int? MontantUsdLiquideFacture { get; set; }

    public string? NomArticle { get; set; }

    public string? NomComposant { get; set; }

    public string? NomEntrepriseExportateur { get; set; }

    public string? NomEntrepriseImportateur { get; set; }

    public string? NomMarque { get; set; }

    public string? NomModeleSpecification { get; set; }

    public string? NumeroArticle { get; set; }

    public string? NumeroDeclarationDetail { get; set; }

    public string? NumeroIdentificationExportateur { get; set; }

    public string? NumeroIdentificationImportateur { get; set; }

    public string? NumeroModeleSpecification { get; set; }

    public int? PoidsNet { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public int? PrixNcyUnitaireDeclare { get; set; }

    public int? PrixUnitaireNcyLiquide { get; set; }

    public int? PrixUnitaireUsdLiquide { get; set; }

    public int? PrixUsdUnitaireDeclare { get; set; }

    public int? Quantite { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }
}

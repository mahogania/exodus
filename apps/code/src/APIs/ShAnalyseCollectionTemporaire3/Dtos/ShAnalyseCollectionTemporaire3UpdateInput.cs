namespace Code.APIs.Dtos;

public class ShAnalyseCollectionTemporaire3UpdateInput
{
    public string? CodeSh { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public string? Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public int? PrixUnitaireNcyMinimum { get; set; }

    public int? PrixUnitaireNcyPlafonne { get; set; }

    public int? PrixUnitaireUsdMinimum { get; set; }

    public int? PrixUnitaireUsdPlafonne { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

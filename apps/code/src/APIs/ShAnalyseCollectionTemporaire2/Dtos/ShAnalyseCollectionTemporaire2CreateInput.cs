namespace Code.APIs.Dtos;

public class ShAnalyseCollectionTemporaire2CreateInput
{
    public int? ClassementGroupesPrixNcyUnitaires { get; set; }

    public int? ClassementGroupesPrixUsdUnitaires { get; set; }

    public string? CodeSh { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public string? Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public int? PrixNcyUnitaire { get; set; }

    public int? PrixUsdUnitaire { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }
}

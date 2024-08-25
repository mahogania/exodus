namespace Code.APIs.Dtos;

public class ArticlePaysPartenaireConventionDouaniereCreateInput
{
    public string? CodeCategorieTarif { get; set; }

    public string? CodePaysPreferentiel { get; set; }

    public string? CodePreferentiel { get; set; }

    public string? CodeSh { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public string? Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public string? Sequence { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }
}

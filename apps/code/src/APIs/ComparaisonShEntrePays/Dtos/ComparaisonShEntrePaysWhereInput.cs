namespace Code.APIs.Dtos;

public class ComparaisonShEntrePaysWhereInput
{
    public string? CodeEmetteurSh { get; set; }

    public string? CodeSh { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public string? DescriptionSh { get; set; }

    public string? Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

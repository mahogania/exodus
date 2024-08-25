namespace Code.APIs.Dtos;

public class PaysPreferentielCreateInput
{
    public string? CodeDePays { get; set; }

    public string? CodePreferentiel { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateDebutApplicationPreference { get; set; }

    public DateTime? DateFinApplicationConvention { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public string? Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? UtiliseOn { get; set; }
}

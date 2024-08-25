namespace Code.APIs.Dtos;

public class PeriodeTarifNormalGeneral
{
    public DateTime CreatedAt { get; set; }

    public DateTime? DateDebutApplication { get; set; }

    public DateTime? DateFinApplication { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public string Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }
}

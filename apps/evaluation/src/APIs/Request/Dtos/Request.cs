namespace Evaluation.APIs.Dtos;

public class Request
{
    public string? AdresseDeLEntreprise { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? DNominationCommerciale { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public string? EmailDeLOpRateur { get; set; }

    public string Id { get; set; }

    public string? IdDuFichierJoint { get; set; }

    public string? IdDuModificateurFinal { get; set; }

    public string? IdDuPremierEnregistrant { get; set; }

    public string? MarqueDeLArticle { get; set; }

    public string? NAlerte { get; set; }

    public string? NDeTlPhonePortableDeLOpRateur { get; set; }

    public string? NFaxDeLOpRateur { get; set; }

    public string? NTlPhoneDeLOpRateur { get; set; }

    public string? NiuDeLEntreprise { get; set; }

    public string? NomDeLEntreprise { get; set; }

    public string? Remarque { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }
}

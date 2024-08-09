namespace Fret.APIs.Dtos;

public class TrailerCreateInput
{
    public DateTime CreatedAt { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public string? GabaritDeRemorque { get; set; }

    public string? Id { get; set; }

    public string? IdDuModificateurFinal { get; set; }

    public string? IdDuPremierEnregistrant { get; set; }

    public string? NDImmatriculationDuVHicule { get; set; }

    public string? NDeChSsis { get; set; }

    public string? NDeSQuenceDeBl { get; set; }

    public string? NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret { get; set; }

    public string? NumRoDeSRieDeLaRemorque { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }
}

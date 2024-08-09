namespace Fret.APIs.Dtos;

public class Vehicle
{
    public string? AnnEDeFabricationDeVHicule { get; set; }

    public string? CodeDeFabricantDuVHicule { get; set; }

    public string? CodeDeModLeDuVHicule { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public string Id { get; set; }

    public string? IdDuModificateurFinal { get; set; }

    public string? IdDuPremierEnregistrant { get; set; }

    public string? NDImmatriculationDuVHicule { get; set; }

    public string? NDeChSsis { get; set; }

    public string? NDeSQuenceDeBl { get; set; }

    public string? NombreDeCylindresDeMoteur { get; set; }

    public string? NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret { get; set; }

    public string? NumRoDeSQuenceDeVHicule { get; set; }

    public string? PoidsTotalEnCharge { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public string? TypeDeVHicule { get; set; }

    public DateTime UpdatedAt { get; set; }
}

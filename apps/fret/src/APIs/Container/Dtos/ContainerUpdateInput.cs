namespace Fret.APIs.Dtos;

public class ContainerUpdateInput
{
    public string? CodeDeLUnitDeColis { get; set; }

    public string? CodeDeTypeDeConteneur { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public string? Id { get; set; }

    public string? IdDuModificateurFinal { get; set; }

    public string? IdDuPremierEnregistrant { get; set; }

    public string? NDeConteneur { get; set; }

    public string? NDeSQuenceDeBl { get; set; }

    public string? NDeSQuenceDuConteneur { get; set; }

    public string? NDeScell_1 { get; set; }

    public string? NDeScell_2 { get; set; }

    public string? NDeScell_3 { get; set; }

    public string? NombreDeColis { get; set; }

    public string? NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret { get; set; }

    public string? PoidsBrut { get; set; }

    public string? ResponsableDeScell_1 { get; set; }

    public string? ResponsableDeScell_2 { get; set; }

    public string? ResponsableDeScell_3 { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public string? TareDeConteneurSVide { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

namespace Fret.APIs.Dtos;

public class TrainWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public string? Id { get; set; }

    public int? IdDuModificateurFinal { get; set; }

    public int? IdDuPremierEnregistrant { get; set; }

    public int? NDeSQuenceDeBl { get; set; }

    public int? NDeWagon { get; set; }

    public string? NEnregistrementDuTrain { get; set; }

    public string? NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret { get; set; }

    public int? NumRoDeSRieDuTrain { get; set; }

    public bool? SuppressionOn { get; set; }

    public string? TypeDeWagon { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

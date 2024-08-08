namespace Evaluation.APIs.Dtos;

public class ExpressWhereInput
{
    public string? CodeDeBureauDeDouane { get; set; }

    public string? CodeDeLOpRateurExpress { get; set; }

    public string? CodeDePaysDeChargement { get; set; }

    public string? CodeDeStatutDeTraitement { get; set; }

    public string? CodeDeTypeDeTransmission { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateDArrivE { get; set; }

    public DateTime? DateDeDemande { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public string? Id { get; set; }

    public string? IdDuFichierJoint { get; set; }

    public string? IdDuModificateurFinal { get; set; }

    public string? IdDuPremierEnregistrant { get; set; }

    public string? NDeDemandeDeDDouanementExpress { get; set; }

    public string? NDeMasterBl { get; set; }

    public string? NomDeLOpRateurExpress { get; set; }

    public string? NomDuNavire { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

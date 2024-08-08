namespace Evaluation.APIs.Dtos;

public class DetailWhereInput
{
    public string? AdreseDeLExpDiteur { get; set; }

    public string? AdresseDeDestinataire { get; set; }

    public string? CodeDIdentificationDeDestinataire { get; set; }

    public string? CodeDeDDouanement { get; set; }

    public string? CodeDeLOpRateurExpress { get; set; }

    public string? CodeDePaysDExpDition { get; set; }

    public string? CodeDeStatutDeTraitement { get; set; }

    public string? CodeDeTransporteur { get; set; }

    public string? CodeDeTypeDeTraitementDeDDouanementExpress { get; set; }

    public string? CodeDeTypeDesFins { get; set; }

    public string? CodePostalDeDestinataire { get; set; }

    public string? CodeSh { get; set; }

    public string? ContenuDeCodeBarre { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? DDouanementOrdinaireOn { get; set; }

    public bool? DDouanementSimplifiOn { get; set; }

    public string? DNominationCommerciale { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public DateTime? DateEtHeureDeTransmissionDeCodeBarre { get; set; }

    public string? Id { get; set; }

    public string? IdDuModificateurFinal { get; set; }

    public string? IdDuPremierEnregistrant { get; set; }

    public double? MontantDeLaTaxeDouaniReSimple { get; set; }

    public string? NDeCertificationDeLEntrepriseDeCommercialLectronique { get; set; }

    public string? NDeDemandeDeDDouanementExpress { get; set; }

    public string? NDeHouseBl { get; set; }

    public string? NDeMasterBl { get; set; }

    public string? NDeSQuence { get; set; }

    public string? NDeTlPhoneDeDestinataire { get; set; }

    public string? NDeTlPhoneDeLExpDiteur { get; set; }

    public string? NomDeDestinataire { get; set; }

    public string? NomDeLExpDiteur { get; set; }

    public string? NoteDeDouane { get; set; }

    public double? Poids { get; set; }

    public int? Quantit { get; set; }

    public int? QuantitDuColis { get; set; }

    public string? SiteInternetDeECommercial { get; set; }

    public string? Standards { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public string? TypeDOpRation { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public double? ValeurDeMarchandise { get; set; }
}

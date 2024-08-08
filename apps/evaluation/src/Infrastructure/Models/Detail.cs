using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluation.Infrastructure.Models;

[Table("Details")]
public class DetailDbModel
{
    [StringLength(1000)]
    public string? AdreseDeLExpDiteur { get; set; }

    [StringLength(1000)]
    public string? AdresseDeDestinataire { get; set; }

    [StringLength(1000)]
    public string? CodeDIdentificationDeDestinataire { get; set; }

    [StringLength(1000)]
    public string? CodeDeDDouanement { get; set; }

    [StringLength(1000)]
    public string? CodeDeLOpRateurExpress { get; set; }

    [StringLength(1000)]
    public string? CodeDePaysDExpDition { get; set; }

    [StringLength(1000)]
    public string? CodeDeStatutDeTraitement { get; set; }

    [StringLength(1000)]
    public string? CodeDeTransporteur { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDeTraitementDeDDouanementExpress { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDesFins { get; set; }

    [StringLength(1000)]
    public string? CodePostalDeDestinataire { get; set; }

    [StringLength(1000)]
    public string? CodeSh { get; set; }

    [StringLength(1000)]
    public string? ContenuDeCodeBarre { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public bool? DDouanementOrdinaireOn { get; set; }

    public bool? DDouanementSimplifiOn { get; set; }

    [StringLength(1000)]
    public string? DNominationCommerciale { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public DateTime? DateEtHeureDeTransmissionDeCodeBarre { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdDuModificateurFinal { get; set; }

    [StringLength(1000)]
    public string? IdDuPremierEnregistrant { get; set; }

    [Range(-999999999, 999999999)]
    public double? MontantDeLaTaxeDouaniReSimple { get; set; }

    [StringLength(1000)]
    public string? NDeCertificationDeLEntrepriseDeCommercialLectronique { get; set; }

    [StringLength(1000)]
    public string? NDeDemandeDeDDouanementExpress { get; set; }

    [StringLength(1000)]
    public string? NDeHouseBl { get; set; }

    [StringLength(1000)]
    public string? NDeMasterBl { get; set; }

    [StringLength(1000)]
    public string? NDeSQuence { get; set; }

    [StringLength(1000)]
    public string? NDeTlPhoneDeDestinataire { get; set; }

    [StringLength(1000)]
    public string? NDeTlPhoneDeLExpDiteur { get; set; }

    [StringLength(1000)]
    public string? NomDeDestinataire { get; set; }

    [StringLength(1000)]
    public string? NomDeLExpDiteur { get; set; }

    [StringLength(1000)]
    public string? NoteDeDouane { get; set; }

    [Range(-999999999, 999999999)]
    public double? Poids { get; set; }

    [Range(-999999999, 999999999)]
    public int? Quantit { get; set; }

    [Range(-999999999, 999999999)]
    public int? QuantitDuColis { get; set; }

    [StringLength(1000)]
    public string? SiteInternetDeECommercial { get; set; }

    [StringLength(1000)]
    public string? Standards { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TypeDOpRation { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [Range(-999999999, 999999999)]
    public double? ValeurDeMarchandise { get; set; }
}

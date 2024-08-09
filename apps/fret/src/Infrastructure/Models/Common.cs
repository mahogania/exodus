using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fret.Infrastructure.Models;

[Table("Commons")]
public class CommonDbModel
{
    public bool? AutoLiquidationOn { get; set; }

    public bool? CargaisonConteneurisEOn { get; set; }

    [StringLength(1000)]
    public string? CodeDAgnceDeBanqueDePaiement { get; set; }

    [StringLength(1000)]
    public string? CodeDEntrepTDeLaMarchandiseSousDouane { get; set; }

    [StringLength(1000)]
    public string? CodeDeBanqueDePaiement { get; set; }

    [StringLength(1000)]
    public string? CodeDeBureauDeDClaration { get; set; }

    [StringLength(1000)]
    public string? CodeDeConditionDeTransaction_1 { get; set; }

    [StringLength(1000)]
    public string? CodeDeConditionDeTransaction_2 { get; set; }

    [StringLength(1000)]
    public string? CodeDeFormulaireDeLaDClaration { get; set; }

    [StringLength(1000)]
    public string? CodeDeLEntrepTPrCDentDeLaMarchandiseSousDouane { get; set; }

    [StringLength(1000)]
    public string? CodeDeLaConditionDeLivraison { get; set; }

    [StringLength(1000)]
    public string? CodeDeLieuDeChargement { get; set; }

    [StringLength(1000)]
    public string? CodeDeLieuDeDChargement { get; set; }

    [StringLength(1000)]
    public string? CodeDeLocalisationDeStockage { get; set; }

    [StringLength(1000)]
    public string? CodeDeModeDePaiement { get; set; }

    [StringLength(1000)]
    public string? CodeDeMotifDeLaModification { get; set; }

    [StringLength(1000)]
    public string? CodeDeNationalitDuMoyenDeTransport { get; set; }

    [StringLength(1000)]
    public string? CodeDePaysDExpDition { get; set; }

    [StringLength(1000)]
    public string? CodeDePaysDeTransaction { get; set; }

    [StringLength(1000)]
    public string? CodeDePaysDestinataire { get; set; }

    [StringLength(1000)]
    public string? CodeDePaysExportateur { get; set; }

    [StringLength(1000)]
    public string? CodeDePlanDeDDouanement { get; set; }

    [StringLength(1000)]
    public string? CodeDeRGionDestinataire { get; set; }

    [StringLength(1000)]
    public string? CodeDeService { get; set; }

    [StringLength(1000)]
    public string? CodeDeStatutDeDomiciliation { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDeDClaration { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDeDDouanementPartiel { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDeNdIdentificationDeLExportateur { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDuMoyenDeTransport { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDuNdIdentificationDeLImportateur { get; set; }

    [StringLength(1000)]
    public string? CodeDuBureauDEntrEEtDeSortie { get; set; }

    [StringLength(1000)]
    public string? CodeDuDClarant { get; set; }

    [StringLength(1000)]
    public string? CodeDuLieuDeLivraison { get; set; }

    [StringLength(1000)]
    public string? CodeEpc { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Crn { get; set; }

    public bool? DClarationDeLaValeurSaisieOn { get; set; }

    public DateTime? DateDArrivE { get; set; }

    public DateTime? DateDMissionDeLaFacture { get; set; }

    public DateTime? DateDeConnaissement { get; set; }

    public DateTime? DateDeDChargement { get; set; }

    public DateTime? DateDeDemande { get; set; }

    public DateTime? DateDeDomiciliation { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public DateTime? DateInitialeDeLaDClaration { get; set; }

    public bool? EnlVementEnVHiculeOn { get; set; }

    public bool? FinalOn { get; set; }

    [Range(-999999999, 999999999)]
    public int? FrQuenceDeRectification { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public int? IdDuModificateurFinal { get; set; }

    [Range(-999999999, 999999999)]
    public int? IdDuPremierEnregistrant { get; set; }

    [StringLength(1000)]
    public string? ModeFinancement { get; set; }

    [StringLength(1000)]
    public string? MotifDeRectification { get; set; }

    [StringLength(1000)]
    public string? NDIdentificationDeLExportateur { get; set; }

    [StringLength(1000)]
    public string? NDIdentificationDeLImportateur { get; set; }

    [StringLength(1000)]
    public string? NDIdentificationDeRedevable { get; set; }

    [StringLength(1000)]
    public string? NDIdentificationDuMoyenDeTransport { get; set; }

    [StringLength(1000)]
    public string? NDeBl { get; set; }

    [StringLength(1000)]
    public string? NDeCompteDePaiement { get; set; }

    [StringLength(1000)]
    public string? NDeDemandeDeRGime { get; set; }

    [StringLength(1000)]
    public string? NDeFacture { get; set; }

    [Range(-999999999, 999999999)]
    public int? NDeRfRence { get; set; }

    [StringLength(1000)]
    public string? NomDuNavire { get; set; }

    [Range(-999999999, 999999999)]
    public int? NombreDArticles { get; set; }

    [Range(-999999999, 999999999)]
    public int? NombreDeConteneurs { get; set; }

    [Range(-999999999, 999999999)]
    public int? NombreTotalDeColis { get; set; }

    [Range(-999999999, 999999999)]
    public int? NumRoDeRfRenceDeVoyageur { get; set; }

    [StringLength(1000)]
    public string? NumRoDeRegistreDeCommerceDeLExportateur { get; set; }

    [StringLength(1000)]
    public string? NumRoDeRegistreDeCommerceDeLImportateur { get; set; }

    [StringLength(1000)]
    public string? NumRoDeRegistreDeCommerceDuRedevable { get; set; }

    [StringLength(1000)]
    public string? NumeroDeLaDClarationEnDTail { get; set; }

    [StringLength(1000)]
    public string? PRiodeDChAnceDeLApurementDeLaGestionEtSuivi { get; set; }

    [Range(-999999999, 999999999)]
    public int? PoidsBrutTotal { get; set; }

    [Range(-999999999, 999999999)]
    public int? PoidsNetTotal { get; set; }

    public bool? SuppressionOn { get; set; }

    [Range(-999999999, 999999999)]
    public int? TempsUtilisationDuSystMeEnSeconde { get; set; }

    [StringLength(1000)]
    public string? TexteDeTraitementDeVoyageur { get; set; }

    [StringLength(1000)]
    public string? TexteLibreRServAuDClarant { get; set; }

    [StringLength(1000)]
    public string? TypeDOpRation { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

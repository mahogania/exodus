using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fret.Infrastructure.Models;

[Table("Lines")]
public class LineDbModel
{
    [StringLength(1000)]
    public string? AdresseAffrTeurSlotteur { get; set; }

    [StringLength(1000)]
    public string? AdresseDeLExpDiteur { get; set; }

    [StringLength(1000)]
    public string? AdresseDeLExportateur { get; set; }

    [StringLength(1000)]
    public string? AdresseDeLaPartieNotifier { get; set; }

    [StringLength(1000)]
    public string? AdresseDuDestinataire { get; set; }

    [StringLength(1000)]
    public string? AffrTeurDEspaceSlot { get; set; }

    [StringLength(1000)]
    public string? ArticleMontantCodeDeDevise { get; set; }

    public DateTime? CabotageOn { get; set; }

    [StringLength(1000)]
    public string? CodeDeCatGorieDeBl { get; set; }

    [StringLength(1000)]
    public string? CodeDeCatGorieDeRectificationDeBl { get; set; }

    [StringLength(1000)]
    public string? CodeDeClasseUndg { get; set; }

    [StringLength(1000)]
    public string? CodeDeGroupeur { get; set; }

    [StringLength(1000)]
    public string? CodeDeLUnitDeColis { get; set; }

    [StringLength(1000)]
    public string? CodeDeLieuDeChargement { get; set; }

    [StringLength(1000)]
    public string? CodeDeLieuDeDChargement { get; set; }

    [StringLength(1000)]
    public string? CodeDeRGionDeTransbordement { get; set; }

    [StringLength(1000)]
    public string? CodeDeStevedoremanutentionnaire { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDHydrocarbure { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDeBl { get; set; }

    [StringLength(1000)]
    public string? CodeDeZoneSousDouane { get; set; }

    [StringLength(1000)]
    public string? CodeSh { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? Crn { get; set; }

    [StringLength(1000)]
    public string? CrnPrCDent { get; set; }

    public DateTime? DChargementOn { get; set; }

    public DateTime? DateEmissionBl { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    [StringLength(1000)]
    public string? EMailDeDestinataire { get; set; }

    [StringLength(1000)]
    public string? EmailDeLExpDiteur { get; set; }

    [StringLength(1000)]
    public string? EmailDeLExportateur { get; set; }

    [StringLength(1000)]
    public string? EmailDeLaPartieNotifier { get; set; }

    [StringLength(1000)]
    public string? Hsn { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdDuModificateurFinal { get; set; }

    [StringLength(1000)]
    public string? IdDuPremierEnregistrant { get; set; }

    [StringLength(1000)]
    public string? IdentifiantUndg { get; set; }

    [StringLength(1000)]
    public string? IndFretPrPayD { get; set; }

    [StringLength(1000)]
    public string? InfoSupplMentaire { get; set; }

    [StringLength(1000)]
    public string? MarqueDeColis { get; set; }

    [StringLength(1000)]
    public string? ModeDeLivraison { get; set; }

    [StringLength(1000)]
    public string? Msn { get; set; }

    [StringLength(1000)]
    public string? NDeBl { get; set; }

    [StringLength(1000)]
    public string? NDeHouseBl { get; set; }

    [StringLength(1000)]
    public string? NDeSQuenceDeBl { get; set; }

    [StringLength(1000)]
    public string? NDeTlPhoneDeDestinataire { get; set; }

    [StringLength(1000)]
    public string? NatureDeCargaison { get; set; }

    [StringLength(1000)]
    public string? NatureDeMarchandise { get; set; }

    [StringLength(1000)]
    public string? NifDeDStinataire { get; set; }

    [StringLength(1000)]
    public string? NifDeLExportateur { get; set; }

    [StringLength(1000)]
    public string? NinDExportateur { get; set; }

    [StringLength(1000)]
    public string? NinDeDStinataire { get; set; }

    [StringLength(1000)]
    public string? NomDeDestinataire { get; set; }

    [StringLength(1000)]
    public string? NomDeLAffrTeurSlotteur { get; set; }

    [StringLength(1000)]
    public string? NomDeLArticle { get; set; }

    [StringLength(1000)]
    public string? NomDeLExpDiteur { get; set; }

    [StringLength(1000)]
    public string? NomDeLExportateur { get; set; }

    [StringLength(1000)]
    public string? NomDeLaPartieNotifier { get; set; }

    [StringLength(1000)]
    public string? NombreDeColis { get; set; }

    [StringLength(1000)]
    public string? NombreDeConteneurs { get; set; }

    [StringLength(1000)]
    public string? NombreDeVHicules { get; set; }

    [StringLength(1000)]
    public string? NombreTotalDeSousBl { get; set; }

    [StringLength(1000)]
    public string? NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret { get; set; }

    [StringLength(1000)]
    public string? NumeroCas { get; set; }

    [StringLength(1000)]
    public string? PoidsBrut { get; set; }

    [StringLength(1000)]
    public string? PoidsNet { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TLPhoneDeLExpDiteur { get; set; }

    [StringLength(1000)]
    public string? TLPhoneDeLExportateur { get; set; }

    [StringLength(1000)]
    public string? TLPhoneDeLaPartieNotifier { get; set; }

    [StringLength(1000)]
    public string? TareDeConteneurSVide { get; set; }

    [StringLength(1000)]
    public string? TypeDeFlux { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    [StringLength(1000)]
    public string? ValeurDeMarchandise { get; set; }

    [StringLength(1000)]
    public string? VolumeLitre { get; set; }

    [StringLength(1000)]
    public string? VolumeMtq { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluation.Infrastructure.Models;

[Table("Expresses")]
public class ExpressDbModel
{
    [StringLength(1000)]
    public string? CodeDeBureauDeDouane { get; set; }

    [StringLength(1000)]
    public string? CodeDeLOpRateurExpress { get; set; }

    [StringLength(1000)]
    public string? CodeDePaysDeChargement { get; set; }

    [StringLength(1000)]
    public string? CodeDeStatutDeTraitement { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDeTransmission { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateDArrivE { get; set; }

    public DateTime? DateDeDemande { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdDuFichierJoint { get; set; }

    [StringLength(1000)]
    public string? IdDuModificateurFinal { get; set; }

    [StringLength(1000)]
    public string? IdDuPremierEnregistrant { get; set; }

    [StringLength(1000)]
    public string? NDeDemandeDeDDouanementExpress { get; set; }

    [StringLength(1000)]
    public string? NDeMasterBl { get; set; }

    [StringLength(1000)]
    public string? NomDeLOpRateurExpress { get; set; }

    [StringLength(1000)]
    public string? NomDuNavire { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

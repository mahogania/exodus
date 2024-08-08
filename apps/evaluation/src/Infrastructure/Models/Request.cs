using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluation.Infrastructure.Models;

[Table("Requests")]
public class RequestDbModel
{
    [StringLength(1000)]
    public string? AdresseDeLEntreprise { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    [StringLength(1000)]
    public string? DNominationCommerciale { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    public string? EmailDeLOpRateur { get; set; }

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
    public string? MarqueDeLArticle { get; set; }

    [StringLength(1000)]
    public string? NAlerte { get; set; }

    [StringLength(1000)]
    public string? NDeTlPhonePortableDeLOpRateur { get; set; }

    [StringLength(1000)]
    public string? NFaxDeLOpRateur { get; set; }

    [StringLength(1000)]
    public string? NTlPhoneDeLOpRateur { get; set; }

    [StringLength(1000)]
    public string? NiuDeLEntreprise { get; set; }

    [StringLength(1000)]
    public string? NomDeLEntreprise { get; set; }

    [StringLength(1000)]
    public string? Remarque { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fret.Infrastructure.Models;

[Table("Containers")]
public class ContainerDbModel
{
    [StringLength(1000)]
    public string? CodeDeLUnitDeColis { get; set; }

    [StringLength(1000)]
    public string? CodeDeTypeDeConteneur { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdDuModificateurFinal { get; set; }

    [StringLength(1000)]
    public string? IdDuPremierEnregistrant { get; set; }

    [StringLength(1000)]
    public string? NDeConteneur { get; set; }

    [StringLength(1000)]
    public string? NDeSQuenceDeBl { get; set; }

    [StringLength(1000)]
    public string? NDeSQuenceDuConteneur { get; set; }

    [StringLength(1000)]
    public string? NDeScell_1 { get; set; }

    [StringLength(1000)]
    public string? NDeScell_2 { get; set; }

    [StringLength(1000)]
    public string? NDeScell_3 { get; set; }

    [StringLength(1000)]
    public string? NombreDeColis { get; set; }

    [StringLength(1000)]
    public string? NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret { get; set; }

    [StringLength(1000)]
    public string? PoidsBrut { get; set; }

    [StringLength(1000)]
    public string? ResponsableDeScell_1 { get; set; }

    [StringLength(1000)]
    public string? ResponsableDeScell_2 { get; set; }

    [StringLength(1000)]
    public string? ResponsableDeScell_3 { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TareDeConteneurSVide { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

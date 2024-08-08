using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fret.Infrastructure.Models;

[Table("Trailers")]
public class TrailerDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    [StringLength(1000)]
    public string? GabaritDeRemorque { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? IdDuModificateurFinal { get; set; }

    [StringLength(1000)]
    public string? IdDuPremierEnregistrant { get; set; }

    [StringLength(1000)]
    public string? NDImmatriculationDuVHicule { get; set; }

    [StringLength(1000)]
    public string? NDeChSsis { get; set; }

    [StringLength(1000)]
    public string? NDeSQuenceDeBl { get; set; }

    [StringLength(1000)]
    public string? NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret { get; set; }

    [StringLength(1000)]
    public string? NumRoDeSRieDeLaRemorque { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

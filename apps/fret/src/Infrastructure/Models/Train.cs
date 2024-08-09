using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fret.Infrastructure.Models;

[Table("Trains")]
public class TrainDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateEtHeureDeModificationFinale { get; set; }

    public DateTime? DateEtHeureDePremierEnregistrement { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public int? IdDuModificateurFinal { get; set; }

    [Range(-999999999, 999999999)]
    public int? IdDuPremierEnregistrant { get; set; }

    [Range(-999999999, 999999999)]
    public int? NDeSQuenceDeBl { get; set; }

    [Range(-999999999, 999999999)]
    public int? NDeWagon { get; set; }

    [StringLength(1000)]
    public string? NEnregistrementDuTrain { get; set; }

    [StringLength(1000)]
    public string? NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret { get; set; }

    [Range(-999999999, 999999999)]
    public int? NumRoDeSRieDuTrain { get; set; }

    public bool? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TypeDeWagon { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

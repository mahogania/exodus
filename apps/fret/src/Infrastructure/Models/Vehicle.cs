using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fret.Infrastructure.Models;

[Table("Vehicles")]
public class VehicleDbModel
{
    [StringLength(1000)]
    public string? AnnEDeFabricationDeVHicule { get; set; }

    [StringLength(1000)]
    public string? CodeDeFabricantDuVHicule { get; set; }

    [StringLength(1000)]
    public string? CodeDeModLeDuVHicule { get; set; }

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
    public string? NDImmatriculationDuVHicule { get; set; }

    [StringLength(1000)]
    public string? NDeChSsis { get; set; }

    [StringLength(1000)]
    public string? NDeSQuenceDeBl { get; set; }

    [StringLength(1000)]
    public string? NombreDeCylindresDeMoteur { get; set; }

    [StringLength(1000)]
    public string? NumRoDeGestionDeLEnregistrementDeLaDClarationDeFret { get; set; }

    [StringLength(1000)]
    public string? NumRoDeSQuenceDeVHicule { get; set; }

    [StringLength(1000)]
    public string? PoidsTotalEnCharge { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [StringLength(1000)]
    public string? TypeDeVHicule { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

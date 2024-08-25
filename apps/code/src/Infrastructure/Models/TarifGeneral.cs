using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("TarifGenerals")]
public class TarifGeneralDbModel
{
    [StringLength(1000)]
    public string? CodeCategorieTarif { get; set; }

    [StringLength(1000)]
    public string? CodeTypeTarif { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    [StringLength(1000)]
    public string? DetailsDroitsAdValoremCommeBaseTaxable { get; set; }

    [StringLength(1000)]
    public string? DetailsDroitsSpecifiquesCommeBaseTaxable { get; set; }

    [StringLength(1000)]
    public string? DetailsTarifAdValorem { get; set; }

    [StringLength(1000)]
    public string? DetailsTarifSpecifique { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public int? ModificateurFinalId { get; set; }

    [Range(-999999999, 999999999)]
    public int? PremierEnregistrantId { get; set; }

    [Range(-999999999, 999999999)]
    public int? Sequence { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }

    public DateTime? UtiliseOn { get; set; }
}

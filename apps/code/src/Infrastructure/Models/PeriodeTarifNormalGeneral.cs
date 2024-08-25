using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("PeriodeTarifNormalGenerals")]
public class PeriodeTarifNormalGeneralDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateDebutApplication { get; set; }

    public DateTime? DateFinApplication { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public int? ModificateurFinalId { get; set; }

    [Range(-999999999, 999999999)]
    public int? PremierEnregistrantId { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

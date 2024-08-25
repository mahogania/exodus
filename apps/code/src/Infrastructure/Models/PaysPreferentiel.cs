using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("PaysPreferentiels")]
public class PaysPreferentielDbModel
{
    [StringLength(1000)]
    public string? CodeDePays { get; set; }

    [StringLength(1000)]
    public string? CodePreferentiel { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateDebutApplicationPreference { get; set; }

    public DateTime? DateFinApplicationConvention { get; set; }

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

    public DateTime? UtiliseOn { get; set; }
}

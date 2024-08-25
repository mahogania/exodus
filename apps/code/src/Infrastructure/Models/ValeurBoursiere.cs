using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code.Infrastructure.Models;

[Table("ValeurBoursieres")]
public class ValeurBoursiereDbModel
{
    [StringLength(1000)]
    public string? CodeDevisePoidsBrutExporte { get; set; }

    [StringLength(1000)]
    public string? CodeDevisePoidsBrutImporte { get; set; }

    [StringLength(1000)]
    public string? CodeDevisePoidsNetExporte { get; set; }

    [StringLength(1000)]
    public string? CodeDevisePoidsNetImporte { get; set; }

    [StringLength(1000)]
    public string? CodeDeviseUnite1QuantiteExportee { get; set; }

    [StringLength(1000)]
    public string? CodeDeviseUnite1QuantiteImportee { get; set; }

    [StringLength(1000)]
    public string? CodeDeviseUnite2QuantiteExportee { get; set; }

    [StringLength(1000)]
    public string? CodeDeviseUnite2QuantiteImportee { get; set; }

    [StringLength(1000)]
    public string? CodeDeviseUnite3QuantiteExportee { get; set; }

    [StringLength(1000)]
    public string? CodeDeviseUnite3QuantiteImportee { get; set; }

    [StringLength(1000)]
    public string? CodeValeurBoursiere { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public DateTime? DateDebutApplicationValeurBoursiere { get; set; }

    public DateTime? DateFinApplicationValeurBoursiere { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Range(-999999999, 999999999)]
    public int? ModificateurFinalId { get; set; }

    [StringLength(1000)]
    public string? NomValeurBoursiere { get; set; }

    [Range(-999999999, 999999999)]
    public int? PremierEnregistrantId { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixBaseTaxableModifieOn { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixLePlusHauxOn { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitairePoidsBrutExporte { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitairePoidsBrutImporte { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitairePoidsNetExporte { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitairePoidsNetImporte { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireUnite1QuantiteExportee { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireUnite1QuantiteImportee { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireUnite2QuantiteExportee { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireUnite2QuantiteImportee { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireUnite3QuantiteExportee { get; set; }

    [Range(-999999999, 999999999)]
    public int? PrixUnitaireUnite3QuantiteImportee { get; set; }

    public DateTime? SuppressionOn { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

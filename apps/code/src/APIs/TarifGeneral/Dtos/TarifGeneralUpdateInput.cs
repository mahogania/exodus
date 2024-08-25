namespace Code.APIs.Dtos;

public class TarifGeneralUpdateInput
{
    public string? CodeCategorieTarif { get; set; }

    public string? CodeTypeTarif { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public string? DetailsDroitsAdValoremCommeBaseTaxable { get; set; }

    public string? DetailsDroitsSpecifiquesCommeBaseTaxable { get; set; }

    public string? DetailsTarifAdValorem { get; set; }

    public string? DetailsTarifSpecifique { get; set; }

    public string? Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public int? Sequence { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? UtiliseOn { get; set; }
}

namespace Code.APIs.Dtos;

public class ArticleTarifWhereInput
{
    public string? CodeCategorieTarif { get; set; }

    public string? CodeProduitNeufEtUsage { get; set; }

    public string? CodeSh { get; set; }

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

    public string? Sequence { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? UtiliseOn { get; set; }
}

namespace Code.APIs.Dtos;

public class ShAnalyseEvolutionPrixCollectionCreateInput
{
    public int? AnneeAddition { get; set; }

    public string? CodeChampPeriodeAddition { get; set; }

    public string? CodeSh { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public string? Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public int? MoisAddition { get; set; }

    public int? MontantNcyFactureDernierePeriodeAddition { get; set; }

    public int? MontantNcyFactureMoisAddition { get; set; }

    public int? NombreDeclarationsDernierePeriodeAddition { get; set; }

    public int? NombreDeclarationsMoisAddition { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public int? TauxAugmentationMontantFacture { get; set; }

    public int? TauxAugmentationNombreDeclarations { get; set; }

    public DateTime UpdatedAt { get; set; }
}

namespace Code.APIs.Dtos;

public class ValeurBoursiere
{
    public string? CodeDevisePoidsBrutExporte { get; set; }

    public string? CodeDevisePoidsBrutImporte { get; set; }

    public string? CodeDevisePoidsNetExporte { get; set; }

    public string? CodeDevisePoidsNetImporte { get; set; }

    public string? CodeDeviseUnite1QuantiteExportee { get; set; }

    public string? CodeDeviseUnite1QuantiteImportee { get; set; }

    public string? CodeDeviseUnite2QuantiteExportee { get; set; }

    public string? CodeDeviseUnite2QuantiteImportee { get; set; }

    public string? CodeDeviseUnite3QuantiteExportee { get; set; }

    public string? CodeDeviseUnite3QuantiteImportee { get; set; }

    public string? CodeValeurBoursiere { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DateDebutApplicationValeurBoursiere { get; set; }

    public DateTime? DateFinApplicationValeurBoursiere { get; set; }

    public DateTime? DateHeureModificationFinale { get; set; }

    public DateTime? DateHeurePremierEnregistrement { get; set; }

    public string Id { get; set; }

    public int? ModificateurFinalId { get; set; }

    public string? NomValeurBoursiere { get; set; }

    public int? PremierEnregistrantId { get; set; }

    public int? PrixBaseTaxableModifieOn { get; set; }

    public int? PrixLePlusHauxOn { get; set; }

    public int? PrixUnitairePoidsBrutExporte { get; set; }

    public int? PrixUnitairePoidsBrutImporte { get; set; }

    public int? PrixUnitairePoidsNetExporte { get; set; }

    public int? PrixUnitairePoidsNetImporte { get; set; }

    public int? PrixUnitaireUnite1QuantiteExportee { get; set; }

    public int? PrixUnitaireUnite1QuantiteImportee { get; set; }

    public int? PrixUnitaireUnite2QuantiteExportee { get; set; }

    public int? PrixUnitaireUnite2QuantiteImportee { get; set; }

    public int? PrixUnitaireUnite3QuantiteExportee { get; set; }

    public int? PrixUnitaireUnite3QuantiteImportee { get; set; }

    public DateTime? SuppressionOn { get; set; }

    public DateTime UpdatedAt { get; set; }
}

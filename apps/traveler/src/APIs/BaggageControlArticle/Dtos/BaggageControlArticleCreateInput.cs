namespace Traveler.APIs.Dtos;

public class BaggageControlArticleCreateInput
{
    public DateTime CreatedAt { get; set; }

    public List<GeneralTravelerInformationTpd>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public List<ImportDeclaration>? ImportDeclarations { get; set; }

    public List<TpdControl>? TpdControls { get; set; }

    public DateTime UpdatedAt { get; set; }
}

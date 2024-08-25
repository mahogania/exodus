namespace Traveler.APIs.Dtos;

public class ImportDeclaration
{
    public string? BaggageControlArticle { get; set; }

    public DateTime CreatedAt { get; set; }

    public List<string>? GeneralTravelerInformationTpds { get; set; }

    public string Id { get; set; }

    public string? TpdControl { get; set; }

    public string? TpdEntryAndExitHistory { get; set; }

    public string? TravelersArticlesEntryExit { get; set; }

    public DateTime UpdatedAt { get; set; }
}

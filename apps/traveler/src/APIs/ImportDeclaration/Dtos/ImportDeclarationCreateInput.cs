namespace Traveler.APIs.Dtos;

public class ImportDeclarationCreateInput
{
    public BaggageControlArticle? BaggageControlArticle { get; set; }

    public DateTime CreatedAt { get; set; }

    public List<GeneralTravelerInformationTpd>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public TpdControl? TpdControl { get; set; }

    public TpdEntryAndExitHistory? TpdEntryAndExitHistory { get; set; }

    public TravelersArticlesEntryExit? TravelersArticlesEntryExit { get; set; }

    public DateTime UpdatedAt { get; set; }
}

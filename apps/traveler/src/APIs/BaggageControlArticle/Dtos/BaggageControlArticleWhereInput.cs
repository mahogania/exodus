namespace Traveler.APIs.Dtos;

public class BaggageControlArticleWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public List<string>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public List<string>? ImportDeclarations { get; set; }

    public List<string>? TpdControls { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

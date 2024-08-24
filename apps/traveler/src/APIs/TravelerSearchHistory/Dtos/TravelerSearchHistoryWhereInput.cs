namespace Traveler.APIs.Dtos;

public class TravelerSearchHistoryWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public List<string>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

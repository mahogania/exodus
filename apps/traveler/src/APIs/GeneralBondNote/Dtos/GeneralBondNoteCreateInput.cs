namespace Traveler.APIs.Dtos;

public class GeneralBondNoteCreateInput
{
    public List<Appeal>? Appeals { get; set; }

    public DateTime CreatedAt { get; set; }

    public List<GeneralTravelerInformationTpd>? GeneralTravelerInformationTpds { get; set; }

    public string? Id { get; set; }

    public DateTime UpdatedAt { get; set; }
}

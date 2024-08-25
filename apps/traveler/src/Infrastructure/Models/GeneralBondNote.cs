using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("GeneralBondNotes")]
public class GeneralBondNoteDbModel
{
    public List<AppealDbModel>? Appeals { get; set; } = new List<AppealDbModel>();

    [Required()]
    public DateTime CreatedAt { get; set; }

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

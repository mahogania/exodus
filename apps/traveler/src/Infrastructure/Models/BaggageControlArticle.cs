using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("BaggageControlArticles")]
public class BaggageControlArticleDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    public List<ImportDeclarationDbModel>? ImportDeclarations { get; set; } =
        new List<ImportDeclarationDbModel>();

    public List<TpdControlDbModel>? TpdControls { get; set; } = new List<TpdControlDbModel>();

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Traveler.Infrastructure.Models;

[Table("ImportDeclarations")]
public class ImportDeclarationDbModel
{
    public string? BaggageControlArticleId { get; set; }

    [ForeignKey(nameof(BaggageControlArticleId))]
    public BaggageControlArticleDbModel? BaggageControlArticle { get; set; } = null;

    [Required()]
    public DateTime CreatedAt { get; set; }

    public List<GeneralTravelerInformationTpdDbModel>? GeneralTravelerInformationTpds { get; set; } =
        new List<GeneralTravelerInformationTpdDbModel>();

    [Key()]
    [Required()]
    public string Id { get; set; }

    public string? TpdControlId { get; set; }

    [ForeignKey(nameof(TpdControlId))]
    public TpdControlDbModel? TpdControl { get; set; } = null;

    public string? TpdEntryAndExitHistoryId { get; set; }

    [ForeignKey(nameof(TpdEntryAndExitHistoryId))]
    public TpdEntryAndExitHistoryDbModel? TpdEntryAndExitHistory { get; set; } = null;

    public string? TravelersArticlesEntryExitId { get; set; }

    [ForeignKey(nameof(TravelersArticlesEntryExitId))]
    public TravelersArticlesEntryExitDbModel? TravelersArticlesEntryExit { get; set; } = null;

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

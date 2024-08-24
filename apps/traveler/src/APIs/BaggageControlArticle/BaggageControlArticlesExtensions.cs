using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class BaggageControlArticlesExtensions
{
    public static BaggageControlArticle ToDto(this BaggageControlArticleDbModel model)
    {
        return new BaggageControlArticle
        {
            CreatedAt = model.CreatedAt,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Id = model.Id,
            ImportDeclarations = model.ImportDeclarations?.Select(x => x.Id).ToList(),
            TpdControls = model.TpdControls?.Select(x => x.Id).ToList(),
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static BaggageControlArticleDbModel ToModel(
        this BaggageControlArticleUpdateInput updateDto,
        BaggageControlArticleWhereUniqueInput uniqueId
    )
    {
        var baggageControlArticle = new BaggageControlArticleDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            baggageControlArticle.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            baggageControlArticle.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return baggageControlArticle;
    }
}

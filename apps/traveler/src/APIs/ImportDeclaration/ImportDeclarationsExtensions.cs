using Traveler.APIs.Dtos;
using Traveler.Infrastructure.Models;

namespace Traveler.APIs.Extensions;

public static class ImportDeclarationsExtensions
{
    public static ImportDeclaration ToDto(this ImportDeclarationDbModel model)
    {
        return new ImportDeclaration
        {
            BaggageControlArticle = model.BaggageControlArticleId,
            CreatedAt = model.CreatedAt,
            GeneralTravelerInformationTpds = model
                .GeneralTravelerInformationTpds?.Select(x => x.Id)
                .ToList(),
            Id = model.Id,
            TpdControl = model.TpdControlId,
            TpdEntryAndExitHistory = model.TpdEntryAndExitHistoryId,
            TravelersArticlesEntryExit = model.TravelersArticlesEntryExitId,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ImportDeclarationDbModel ToModel(
        this ImportDeclarationUpdateInput updateDto,
        ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        var importDeclaration = new ImportDeclarationDbModel { Id = uniqueId.Id };

        if (updateDto.BaggageControlArticle != null)
        {
            importDeclaration.BaggageControlArticleId = updateDto.BaggageControlArticle;
        }
        if (updateDto.CreatedAt != null)
        {
            importDeclaration.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.TpdControl != null)
        {
            importDeclaration.TpdControlId = updateDto.TpdControl;
        }
        if (updateDto.TpdEntryAndExitHistory != null)
        {
            importDeclaration.TpdEntryAndExitHistoryId = updateDto.TpdEntryAndExitHistory;
        }
        if (updateDto.TravelersArticlesEntryExit != null)
        {
            importDeclaration.TravelersArticlesEntryExitId = updateDto.TravelersArticlesEntryExit;
        }
        if (updateDto.UpdatedAt != null)
        {
            importDeclaration.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return importDeclaration;
    }
}

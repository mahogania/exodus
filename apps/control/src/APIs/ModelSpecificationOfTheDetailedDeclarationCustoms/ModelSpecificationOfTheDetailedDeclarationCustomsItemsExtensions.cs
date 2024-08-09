using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ModelSpecificationOfTheDetailedDeclarationCustomsItemsExtensions
{
    public static ModelSpecificationOfTheDetailedDeclarationCustoms ToDto(
        this ModelSpecificationOfTheDetailedDeclarationCustomsDbModel model
    )
    {
        return new ModelSpecificationOfTheDetailedDeclarationCustoms
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ModelSpecificationOfTheDetailedDeclarationCustomsDbModel ToModel(
        this ModelSpecificationOfTheDetailedDeclarationCustomsUpdateInput updateDto,
        ModelSpecificationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var modelSpecificationOfTheDetailedDeclarationCustoms =
            new ModelSpecificationOfTheDetailedDeclarationCustomsDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            modelSpecificationOfTheDetailedDeclarationCustoms.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            modelSpecificationOfTheDetailedDeclarationCustoms.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return modelSpecificationOfTheDetailedDeclarationCustoms;
    }
}

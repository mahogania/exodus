using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class JointDocumentOfTheDetailedDeclarationCustomsItemsExtensions
{
    public static JointDocumentOfTheDetailedDeclarationCustoms ToDto(
        this JointDocumentOfTheDetailedDeclarationCustomsDbModel model
    )
    {
        return new JointDocumentOfTheDetailedDeclarationCustoms
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static JointDocumentOfTheDetailedDeclarationCustomsDbModel ToModel(
        this JointDocumentOfTheDetailedDeclarationCustomsUpdateInput updateDto,
        JointDocumentOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var jointDocumentOfTheDetailedDeclarationCustoms =
            new JointDocumentOfTheDetailedDeclarationCustomsDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            jointDocumentOfTheDetailedDeclarationCustoms.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            jointDocumentOfTheDetailedDeclarationCustoms.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return jointDocumentOfTheDetailedDeclarationCustoms;
    }
}

using Clre.APIs.Dtos;
using Clre.Infrastructure.Models;

namespace Clre.APIs.Extensions;

public static class AtWithReExportationInTheStatesExtensions
{
    public static AtWithReExportationInTheState ToDto(
        this AtWithReExportationInTheStateDbModel model
    )
    {
        return new AtWithReExportationInTheState
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static AtWithReExportationInTheStateDbModel ToModel(
        this AtWithReExportationInTheStateUpdateInput updateDto,
        AtWithReExportationInTheStateWhereUniqueInput uniqueId
    )
    {
        var atWithReExportationInTheState = new AtWithReExportationInTheStateDbModel
        {
            Id = uniqueId.Id
        };

        if (updateDto.CreatedAt != null)
        {
            atWithReExportationInTheState.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            atWithReExportationInTheState.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return atWithReExportationInTheState;
    }
}

using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class ClearanceFretContainersExtensions
{
    public static ClearanceFretContainer ToDto(this ClearanceFretContainerDbModel model)
    {
        return new ClearanceFretContainer
        {
            ClearanceFretInterface = model.ClearanceFretInterfaceId,
            ContainerId = model.ContainerId,
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ClearanceFretContainerDbModel ToModel(
        this ClearanceFretContainerUpdateInput updateDto,
        ClearanceFretContainerWhereUniqueInput uniqueId
    )
    {
        var clearanceFretContainer = new ClearanceFretContainerDbModel { Id = uniqueId.Id };

        if (updateDto.ClearanceFretInterface != null)
        {
            clearanceFretContainer.ClearanceFretInterfaceId = updateDto.ClearanceFretInterface;
        }
        if (updateDto.ContainerId != null)
        {
            clearanceFretContainer.ContainerId = updateDto.ContainerId;
        }
        if (updateDto.CreatedAt != null)
        {
            clearanceFretContainer.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            clearanceFretContainer.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return clearanceFretContainer;
    }
}

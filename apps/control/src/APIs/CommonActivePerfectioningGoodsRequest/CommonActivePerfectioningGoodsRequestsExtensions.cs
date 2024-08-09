using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonActivePerfectioningGoodsRequestsExtensions
{
    public static CommonActivePerfectioningGoodsRequest ToDto(
        this CommonActivePerfectioningGoodsRequestDbModel model
    )
    {
        return new CommonActivePerfectioningGoodsRequest
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CommonActivePerfectioningGoodsRequestDbModel ToModel(
        this CommonActivePerfectioningGoodsRequestUpdateInput updateDto,
        CommonActivePerfectioningGoodsRequestWhereUniqueInput uniqueId
    )
    {
        var commonActivePerfectioningGoodsRequest = new CommonActivePerfectioningGoodsRequestDbModel
        {
            Id = uniqueId.Id
        };

        if (updateDto.CreatedAt != null)
        {
            commonActivePerfectioningGoodsRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            commonActivePerfectioningGoodsRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return commonActivePerfectioningGoodsRequest;
    }
}

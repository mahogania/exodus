using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonActiveGoodsRequestsExtensions
{
    public static CommonActiveGoodsRequest ToDto(this CommonActiveGoodsRequestDbModel model)
    {
        return new CommonActiveGoodsRequest
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CommonActiveGoodsRequestDbModel ToModel(
        this CommonActiveGoodsRequestUpdateInput updateDto,
        CommonActiveGoodsRequestWhereUniqueInput uniqueId
    )
    {
        var commonActiveGoodsRequest = new CommonActiveGoodsRequestDbModel { Id = uniqueId.Id };

        if (updateDto.CreatedAt != null)
        {
            commonActiveGoodsRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            commonActiveGoodsRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return commonActiveGoodsRequest;
    }
}

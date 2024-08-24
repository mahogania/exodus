using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CarnetRequestsExtensions
{
    public static CarnetRequest ToDto(this CarnetRequestDbModel model)
    {
        return new CarnetRequest
        {
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static CarnetRequestDbModel ToModel(
        this CarnetRequestUpdateInput updateDto,
        CarnetRequestWhereUniqueInput uniqueId
    )
    {
        var carnetRequest = new CarnetRequestDbModel
        {
            Id = uniqueId.Id,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet
        };

        if (updateDto.CreatedAt != null)
        {
            carnetRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            carnetRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return carnetRequest;
    }
}

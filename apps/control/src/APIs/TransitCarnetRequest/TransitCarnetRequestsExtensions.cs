using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class TransitCarnetRequestsExtensions
{
    public static TransitCarnetRequest ToDto(this TransitCarnetRequestDbModel model)
    {
        return new TransitCarnetRequest
        {
            CarnetNumber = model.CarnetNumber,
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            ReferenceNo = model.ReferenceNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TransitCarnetRequestDbModel ToModel(
        this TransitCarnetRequestUpdateInput updateDto,
        TransitCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var transitCarnetRequest = new TransitCarnetRequestDbModel
        {
            Id = uniqueId.Id,
            CarnetNumber = updateDto.CarnetNumber,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            ReferenceNo = updateDto.ReferenceNo
        };

        if (updateDto.CreatedAt != null)
        {
            transitCarnetRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            transitCarnetRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return transitCarnetRequest;
    }
}

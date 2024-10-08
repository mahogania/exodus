using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class TransitCarnetRequestsExtensions
{
    public static TransitCarnetRequest ToDto(this TransitCarnetRequestDbModel model)
    {
        return new TransitCarnetRequest
        {
            CarnetTypeCode = model.CarnetTypeCode,
            CommonCarnetRequest = model.CommonCarnetRequestId,
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            ReferenceNo = model.ReferenceNo,
            TransitCarnetControl = model.TransitCarnetControlId,
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
            CarnetTypeCode = updateDto.CarnetTypeCode,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            ReferenceNo = updateDto.ReferenceNo
        };

        if (updateDto.CommonCarnetRequest != null)
        {
            transitCarnetRequest.CommonCarnetRequestId = updateDto.CommonCarnetRequest;
        }
        if (updateDto.CreatedAt != null)
        {
            transitCarnetRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.TransitCarnetControl != null)
        {
            transitCarnetRequest.TransitCarnetControlId = updateDto.TransitCarnetControl;
        }
        if (updateDto.UpdatedAt != null)
        {
            transitCarnetRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return transitCarnetRequest;
    }
}

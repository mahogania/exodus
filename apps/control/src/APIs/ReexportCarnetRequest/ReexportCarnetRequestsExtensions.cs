using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ReexportCarnetRequestsExtensions
{
    public static ReexportCarnetRequest ToDto(this ReexportCarnetRequestDbModel model)
    {
        return new ReexportCarnetRequest
        {
            CarnetNumber = model.CarnetNumber,
            CarnetTypeCode = model.CarnetTypeCode,
            CommonCarnetRequest = model.CommonCarnetRequestId,
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            ReexportCarnetControl = model.ReexportCarnetControl?.ToDto(),
            ReferenceNo = model.ReferenceNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ReexportCarnetRequestDbModel ToModel(
        this ReexportCarnetRequestUpdateInput updateDto,
        ReexportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var reexportCarnetRequest = new ReexportCarnetRequestDbModel
        {
            Id = uniqueId.Id,
            CarnetNumber = updateDto.CarnetNumber,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            ReferenceNo = updateDto.ReferenceNo
        };

        if (updateDto.CommonCarnetRequest != null)
        {
            reexportCarnetRequest.CommonCarnetRequestId = updateDto.CommonCarnetRequest;
        }
        if (updateDto.CreatedAt != null)
        {
            reexportCarnetRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            reexportCarnetRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return reexportCarnetRequest;
    }
}

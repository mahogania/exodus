using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ExtendedPeriodCarnetRequestsExtensions
{
    public static ExtendedPeriodCarnetRequest ToDto(this ExtendedPeriodCarnetRequestDbModel model)
    {
        return new ExtendedPeriodCarnetRequest
        {
            CarnetRequest = model.CarnetRequest?.ToDto(),
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            ExtendedPeriodCarnetControl = model.ExtendedPeriodCarnetControl?.ToDto(),
            Id = model.Id,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            SequenceNumber = model.SequenceNumber,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ExtendedPeriodCarnetRequestDbModel ToModel(
        this ExtendedPeriodCarnetRequestUpdateInput updateDto,
        ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var extendedPeriodCarnetRequest = new ExtendedPeriodCarnetRequestDbModel
        {
            Id = uniqueId.Id,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            SequenceNumber = updateDto.SequenceNumber
        };

        if (updateDto.CreatedAt != null)
        {
            extendedPeriodCarnetRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            extendedPeriodCarnetRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return extendedPeriodCarnetRequest;
    }
}

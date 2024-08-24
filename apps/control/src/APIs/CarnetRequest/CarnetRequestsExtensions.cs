using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CarnetRequestsExtensions
{
    public static CarnetRequest ToDto(this CarnetRequestDbModel model)
    {
        return new CarnetRequest
        {
            ArticleCarnetRequests = model.ArticleCarnetRequests?.Select(x => x.Id).ToList(),
            CarnetTypeCode = model.CarnetTypeCode,
            CommonCarnetRequest = model.CommonCarnetRequestId,
            CreatedAt = model.CreatedAt,
            ExtendedPeriodCarnetRequests = model.ExtendedPeriodCarnetRequestsId,
            Id = model.Id,
            ImportCarnetRequests = model.ImportCarnetRequests?.Select(x => x.Id).ToList(),
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            ReexportCarnetRequests = model.ReexportCarnetRequests?.Select(x => x.Id).ToList(),
            TransitCarnetRequests = model.TransitCarnetRequests?.Select(x => x.Id).ToList(),
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

        if (updateDto.CommonCarnetRequest != null)
        {
            carnetRequest.CommonCarnetRequestId = updateDto.CommonCarnetRequest;
        }
        if (updateDto.CreatedAt != null)
        {
            carnetRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.ExtendedPeriodCarnetRequests != null)
        {
            carnetRequest.ExtendedPeriodCarnetRequestsId = updateDto.ExtendedPeriodCarnetRequests;
        }
        if (updateDto.UpdatedAt != null)
        {
            carnetRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return carnetRequest;
    }
}

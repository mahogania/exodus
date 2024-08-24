using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ArticleCarnetRequestsExtensions
{
    public static ArticleCarnetRequest ToDto(this ArticleCarnetRequestDbModel model)
    {
        return new ArticleCarnetRequest
        {
            ArticleCarnetControl = model.ArticleCarnetControlId,
            ArticleNumber = model.ArticleNumber,
            CarnetNumber = model.CarnetNumber,
            CarnetRequest = model.CarnetRequestId,
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            OperationTypeCode = model.OperationTypeCode,
            ReferenceNo = model.ReferenceNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ArticleCarnetRequestDbModel ToModel(
        this ArticleCarnetRequestUpdateInput updateDto,
        ArticleCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var articleCarnetRequest = new ArticleCarnetRequestDbModel
        {
            Id = uniqueId.Id,
            ArticleNumber = updateDto.ArticleNumber,
            CarnetNumber = updateDto.CarnetNumber,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            OperationTypeCode = updateDto.OperationTypeCode,
            ReferenceNo = updateDto.ReferenceNo
        };

        if (updateDto.ArticleCarnetControl != null)
        {
            articleCarnetRequest.ArticleCarnetControlId = updateDto.ArticleCarnetControl;
        }
        if (updateDto.CarnetRequest != null)
        {
            articleCarnetRequest.CarnetRequestId = updateDto.CarnetRequest;
        }
        if (updateDto.CreatedAt != null)
        {
            articleCarnetRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            articleCarnetRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return articleCarnetRequest;
    }
}

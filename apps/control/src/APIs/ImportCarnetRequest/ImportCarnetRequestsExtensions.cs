using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ImportCarnetRequestsExtensions
{
    public static ImportCarnetRequest ToDto(this ImportCarnetRequestDbModel model)
    {
        return new ImportCarnetRequest
        {
            CarnetNumber = model.CarnetNumber,
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            ImportCarnetControl = model.ImportCarnetControlId,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            ReferenceNo = model.ReferenceNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ImportCarnetRequestDbModel ToModel(
        this ImportCarnetRequestUpdateInput updateDto,
        ImportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var importCarnetRequest = new ImportCarnetRequestDbModel
        {
            Id = uniqueId.Id,
            CarnetNumber = updateDto.CarnetNumber,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            ReferenceNo = updateDto.ReferenceNo
        };

        if (updateDto.CreatedAt != null)
        {
            importCarnetRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.ImportCarnetControl != null)
        {
            importCarnetRequest.ImportCarnetControlId = updateDto.ImportCarnetControl;
        }
        if (updateDto.UpdatedAt != null)
        {
            importCarnetRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return importCarnetRequest;
    }
}

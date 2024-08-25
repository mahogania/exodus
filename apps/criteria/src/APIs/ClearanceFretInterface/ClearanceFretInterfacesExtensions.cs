using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class ClearanceFretInterfacesExtensions
{
    public static ClearanceFretInterface ToDto(this ClearanceFretInterfaceDbModel model)
    {
        return new ClearanceFretInterface
        {
            AuthorizedGrossWeight = model.AuthorizedGrossWeight,
            AuthorizedNetWeightUnitCodeProcessingOn = model.AuthorizedNetWeightUnitCodeProcessingOn,
            AuthorizedPackageUnitCode = model.AuthorizedPackageUnitCode,
            AuthorizedPackagingNumber = model.AuthorizedPackagingNumber,
            ClearanceFretContainer = model.ClearanceFretContainer?.Select(x => x.Id).ToList(),
            ContainerizedCargoStorageLocationCode = model.ContainerizedCargoStorageLocationCode,
            CreatedAt = model.CreatedAt,
            Crn = model.Crn,
            DeclarantCode = model.DeclarantCode,
            DeclarationTypeCode = model.DeclarationTypeCode,
            DetailedDeclarationNumber = model.DetailedDeclarationNumber,
            EpcCode = model.EpcCode,
            Id = model.Id,
            ProcessingContent = model.ProcessingContent,
            ProcessingResultCode = model.ProcessingResultCode,
            UpdatedAt = model.UpdatedAt,
            ValidationDate = model.ValidationDate,
        };
    }

    public static ClearanceFretInterfaceDbModel ToModel(
        this ClearanceFretInterfaceUpdateInput updateDto,
        ClearanceFretInterfaceWhereUniqueInput uniqueId
    )
    {
        var clearanceFretInterface = new ClearanceFretInterfaceDbModel
        {
            Id = uniqueId.Id,
            AuthorizedGrossWeight = updateDto.AuthorizedGrossWeight,
            AuthorizedNetWeightUnitCodeProcessingOn =
                updateDto.AuthorizedNetWeightUnitCodeProcessingOn,
            AuthorizedPackageUnitCode = updateDto.AuthorizedPackageUnitCode,
            AuthorizedPackagingNumber = updateDto.AuthorizedPackagingNumber,
            ContainerizedCargoStorageLocationCode = updateDto.ContainerizedCargoStorageLocationCode,
            Crn = updateDto.Crn,
            DeclarantCode = updateDto.DeclarantCode,
            DeclarationTypeCode = updateDto.DeclarationTypeCode,
            DetailedDeclarationNumber = updateDto.DetailedDeclarationNumber,
            EpcCode = updateDto.EpcCode,
            ProcessingContent = updateDto.ProcessingContent,
            ProcessingResultCode = updateDto.ProcessingResultCode,
            ValidationDate = updateDto.ValidationDate
        };

        if (updateDto.CreatedAt != null)
        {
            clearanceFretInterface.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            clearanceFretInterface.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return clearanceFretInterface;
    }
}

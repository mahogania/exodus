using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class FineRequestsExtensions
{
    public static FineRequest ToDto(this FineRequestDbModel model)
    {
        return new FineRequest
        {
            AlignmentOrder = model.AlignmentOrder,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FineAmount = model.FineAmount,
            FineImpositionRequestNumber = model.FineImpositionRequestNumber,
            FineRelatedTaxCode = model.FineRelatedTaxCode,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            InfractionCode = model.InfractionCode,
            MaximumAmount = model.MaximumAmount,
            MinimumAmount = model.MinimumAmount,
            OperationTypeCode = model.OperationTypeCode,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static FineRequestDbModel ToModel(
        this FineRequestUpdateInput updateDto,
        FineRequestWhereUniqueInput uniqueId
    )
    {
        var fineRequest = new FineRequestDbModel
        {
            Id = uniqueId.Id,
            AlignmentOrder = updateDto.AlignmentOrder,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FineAmount = updateDto.FineAmount,
            FineImpositionRequestNumber = updateDto.FineImpositionRequestNumber,
            FineRelatedTaxCode = updateDto.FineRelatedTaxCode,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            InfractionCode = updateDto.InfractionCode,
            MaximumAmount = updateDto.MaximumAmount,
            MinimumAmount = updateDto.MinimumAmount,
            OperationTypeCode = updateDto.OperationTypeCode
        };

        if (updateDto.CreatedAt != null)
        {
            fineRequest.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            fineRequest.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return fineRequest;
    }
}

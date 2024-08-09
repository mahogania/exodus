using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class FineRequestHistoriesExtensions
{
    public static FineRequestHistory ToDto(this FineRequestHistoryDbModel model)
    {
        return new FineRequestHistory
        {
            AlignmentOrder = model.AlignmentOrder,
            CappedAmount = model.CappedAmount,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FineAmount = model.FineAmount,
            FineImpositionRequestNo = model.FineImpositionRequestNo,
            FineRelatedTaxCode = model.FineRelatedTaxCode,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            FloorAmount = model.FloorAmount,
            Id = model.Id,
            InfractionCode = model.InfractionCode,
            OperationTypeCode = model.OperationTypeCode,
            RequestOrderNumber = model.RequestOrderNumber,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static FineRequestHistoryDbModel ToModel(
        this FineRequestHistoryUpdateInput updateDto,
        FineRequestHistoryWhereUniqueInput uniqueId
    )
    {
        var fineRequestHistory = new FineRequestHistoryDbModel
        {
            Id = uniqueId.Id,
            AlignmentOrder = updateDto.AlignmentOrder,
            CappedAmount = updateDto.CappedAmount,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FineAmount = updateDto.FineAmount,
            FineImpositionRequestNo = updateDto.FineImpositionRequestNo,
            FineRelatedTaxCode = updateDto.FineRelatedTaxCode,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            FloorAmount = updateDto.FloorAmount,
            InfractionCode = updateDto.InfractionCode,
            OperationTypeCode = updateDto.OperationTypeCode,
            RequestOrderNumber = updateDto.RequestOrderNumber
        };

        if (updateDto.CreatedAt != null)
        {
            fineRequestHistory.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            fineRequestHistory.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return fineRequestHistory;
    }
}

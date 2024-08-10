using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class FineCausesExtensions
{
    public static FineCause ToDto(this FineCauseDbModel model)
    {
        return new FineCause
        {
            AlignmentOrder = model.AlignmentOrder,
            CappedAmount = model.CappedAmount,
            CreatedAt = model.CreatedAt,
            DeletionFlag = model.DeletionFlag,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FineAmount = model.FineAmount,
            FineTaxCode = model.FineTaxCode,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            InfractionCode = model.InfractionCode,
            MinimumAmount = model.MinimumAmount,
            NoticeNumber = model.NoticeNumber,
            OperationTypeCode = model.OperationTypeCode,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static FineCauseDbModel ToModel(
        this FineCauseUpdateInput updateDto,
        FineCauseWhereUniqueInput uniqueId
    )
    {
        var fineCause = new FineCauseDbModel
        {
            Id = uniqueId.Id,
            AlignmentOrder = updateDto.AlignmentOrder,
            CappedAmount = updateDto.CappedAmount,
            DeletionFlag = updateDto.DeletionFlag,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FineAmount = updateDto.FineAmount,
            FineTaxCode = updateDto.FineTaxCode,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            InfractionCode = updateDto.InfractionCode,
            MinimumAmount = updateDto.MinimumAmount,
            NoticeNumber = updateDto.NoticeNumber,
            OperationTypeCode = updateDto.OperationTypeCode
        };

        if (updateDto.CreatedAt != null) fineCause.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) fineCause.UpdatedAt = updateDto.UpdatedAt.Value;

        return fineCause;
    }
}

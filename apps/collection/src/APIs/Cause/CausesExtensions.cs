using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class CausesExtensions
{
    public static Cause ToDto(this CauseDbModel model)
    {
        return new Cause
        {
            AlignmentOrder = model.AlignmentOrder,
            AmountActuallyPaid = model.AmountActuallyPaid,
            AmountOfOtherChargeableFees = model.AmountOfOtherChargeableFees,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NoticeNo = model.NoticeNo,
            OtherChargeableFeesCode = model.OtherChargeableFeesCode,
            OtherChargeableFeesTaxCode = model.OtherChargeableFeesTaxCode,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static CauseDbModel ToModel(
        this CauseUpdateInput updateDto,
        CauseWhereUniqueInput uniqueId
    )
    {
        var cause = new CauseDbModel
        {
            Id = uniqueId.Id,
            AlignmentOrder = updateDto.AlignmentOrder,
            AmountActuallyPaid = updateDto.AmountActuallyPaid,
            AmountOfOtherChargeableFees = updateDto.AmountOfOtherChargeableFees,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NoticeNo = updateDto.NoticeNo,
            OtherChargeableFeesCode = updateDto.OtherChargeableFeesCode,
            OtherChargeableFeesTaxCode = updateDto.OtherChargeableFeesTaxCode
        };

        if (updateDto.CreatedAt != null) cause.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) cause.UpdatedAt = updateDto.UpdatedAt.Value;

        return cause;
    }
}

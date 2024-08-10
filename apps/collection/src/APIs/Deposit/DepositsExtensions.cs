using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class DepositsExtensions
{
    public static Deposit ToDto(this DepositDbModel model)
    {
        return new Deposit
        {
            AmountUsed = model.AmountUsed,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            DepositCeiling = model.DepositCeiling,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NumberOfTimesUsed = model.NumberOfTimesUsed,
            ReferenceNo = model.ReferenceNo,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            RequestNo = model.RequestNo,
            UpdatedAt = model.UpdatedAt,
            UsageMoment = model.UsageMoment
        };
    }

    public static DepositDbModel ToModel(
        this DepositUpdateInput updateDto,
        DepositWhereUniqueInput uniqueId
    )
    {
        var deposit = new DepositDbModel
        {
            Id = uniqueId.Id,
            AmountUsed = updateDto.AmountUsed,
            DeletionOn = updateDto.DeletionOn,
            DepositCeiling = updateDto.DepositCeiling,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NumberOfTimesUsed = updateDto.NumberOfTimesUsed,
            ReferenceNo = updateDto.ReferenceNo,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            RequestNo = updateDto.RequestNo,
            UsageMoment = updateDto.UsageMoment
        };

        if (updateDto.CreatedAt != null) deposit.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) deposit.UpdatedAt = updateDto.UpdatedAt.Value;

        return deposit;
    }
}

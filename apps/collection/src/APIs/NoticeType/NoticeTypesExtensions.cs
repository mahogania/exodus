using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class NoticeTypesExtensions
{
    public static NoticeType ToDto(this NoticeTypeDbModel model)
    {
        return new NoticeType
        {
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            LatePaymentInterestAmountCapRate = model.LatePaymentInterestAmountCapRate,
            LatePaymentInterestRate = model.LatePaymentInterestRate,
            NoticeTypeCode = model.NoticeTypeCode,
            NumberOfDueDays = model.NumberOfDueDays,
            NumberOfTimesUsed = model.NumberOfTimesUsed,
            UpdatedAt = model.UpdatedAt,
            UsedOn = model.UsedOn,
        };
    }

    public static NoticeTypeDbModel ToModel(
        this NoticeTypeUpdateInput updateDto,
        NoticeTypeWhereUniqueInput uniqueId
    )
    {
        var noticeType = new NoticeTypeDbModel
        {
            Id = uniqueId.Id,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            LatePaymentInterestAmountCapRate = updateDto.LatePaymentInterestAmountCapRate,
            LatePaymentInterestRate = updateDto.LatePaymentInterestRate,
            NoticeTypeCode = updateDto.NoticeTypeCode,
            NumberOfDueDays = updateDto.NumberOfDueDays,
            NumberOfTimesUsed = updateDto.NumberOfTimesUsed,
            UsedOn = updateDto.UsedOn
        };

        if (updateDto.CreatedAt != null)
        {
            noticeType.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            noticeType.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return noticeType;
    }
}

using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class FormalNoticesExtensions
{
    public static FormalNotice ToDto(this FormalNoticeDbModel model)
    {
        return new FormalNotice
        {
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            FormalNoticeNumber = model.FormalNoticeNumber,
            Id = model.Id,
            InitialApAmount = model.InitialApAmount,
            LatePaymentDate = model.LatePaymentDate,
            LatePaymentInterestAmount = model.LatePaymentInterestAmount,
            NoticeNumber = model.NoticeNumber,
            NotificationDate = model.NotificationDate,
            NumberOfFormalNotices = model.NumberOfFormalNotices,
            NumberOfLatePayments = model.NumberOfLatePayments,
            PaymentDeadline = model.PaymentDeadline,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static FormalNoticeDbModel ToModel(
        this FormalNoticeUpdateInput updateDto,
        FormalNoticeWhereUniqueInput uniqueId
    )
    {
        var formalNotice = new FormalNoticeDbModel
        {
            Id = uniqueId.Id,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            FormalNoticeNumber = updateDto.FormalNoticeNumber,
            InitialApAmount = updateDto.InitialApAmount,
            LatePaymentDate = updateDto.LatePaymentDate,
            LatePaymentInterestAmount = updateDto.LatePaymentInterestAmount,
            NoticeNumber = updateDto.NoticeNumber,
            NotificationDate = updateDto.NotificationDate,
            NumberOfFormalNotices = updateDto.NumberOfFormalNotices,
            NumberOfLatePayments = updateDto.NumberOfLatePayments,
            PaymentDeadline = updateDto.PaymentDeadline
        };

        if (updateDto.CreatedAt != null) formalNotice.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) formalNotice.UpdatedAt = updateDto.UpdatedAt.Value;

        return formalNotice;
    }
}

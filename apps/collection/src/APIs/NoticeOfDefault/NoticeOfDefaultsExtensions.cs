using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class NoticeOfDefaultsExtensions
{
    public static NoticeOfDefault ToDto(this NoticeOfDefaultDbModel model)
    {
        return new NoticeOfDefault
        {
            CreatedAt = model.CreatedAt,
            DefaultNoticeNumber = model.DefaultNoticeNumber,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            InitialApAmount = model.InitialApAmount,
            LatePaymentDate = model.LatePaymentDate,
            LatePaymentInterestAmount = model.LatePaymentInterestAmount,
            NoticeNumber = model.NoticeNumber,
            NotificationDate = model.NotificationDate,
            NumberOfDefaultNotices = model.NumberOfDefaultNotices,
            NumberOfLatePayments = model.NumberOfLatePayments,
            PaymentDeadline = model.PaymentDeadline,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static NoticeOfDefaultDbModel ToModel(
        this NoticeOfDefaultUpdateInput updateDto,
        NoticeOfDefaultWhereUniqueInput uniqueId
    )
    {
        var noticeOfDefault = new NoticeOfDefaultDbModel
        {
            Id = uniqueId.Id,
            DefaultNoticeNumber = updateDto.DefaultNoticeNumber,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            InitialApAmount = updateDto.InitialApAmount,
            LatePaymentDate = updateDto.LatePaymentDate,
            LatePaymentInterestAmount = updateDto.LatePaymentInterestAmount,
            NoticeNumber = updateDto.NoticeNumber,
            NotificationDate = updateDto.NotificationDate,
            NumberOfDefaultNotices = updateDto.NumberOfDefaultNotices,
            NumberOfLatePayments = updateDto.NumberOfLatePayments,
            PaymentDeadline = updateDto.PaymentDeadline
        };

        if (updateDto.CreatedAt != null)
        {
            noticeOfDefault.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            noticeOfDefault.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return noticeOfDefault;
    }
}

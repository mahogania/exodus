using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class DelaysExtensions
{
    public static Delay ToDto(this DelayDbModel model)
    {
        return new Delay
        {
            CreatedAt = model.CreatedAt,
            DeletionFlag = model.DeletionFlag,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            LatePaymentDate = model.LatePaymentDate,
            LatePaymentInterestAmount = model.LatePaymentInterestAmount,
            LatePaymentInterestAmountExistingBeforeLatePayment =
                model.LatePaymentInterestAmountExistingBeforeLatePayment,
            NoticeNumber = model.NoticeNumber,
            NotificationDate = model.NotificationDate,
            NumberOfTimesOfLatePayments = model.NumberOfTimesOfLatePayments,
            OfficeCode = model.OfficeCode,
            PaymentDeadline = model.PaymentDeadline,
            PenaltyRate = model.PenaltyRate,
            PreviousDueDate = model.PreviousDueDate,
            PreviousNotificationDate = model.PreviousNotificationDate,
            ServiceCode = model.ServiceCode,
            TotalNoticeAmount = model.TotalNoticeAmount,
            TotalPreviousNoticeAmount = model.TotalPreviousNoticeAmount,
            UnadjustedLatePaymentInterestAmount = model.UnadjustedLatePaymentInterestAmount,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static DelayDbModel ToModel(
        this DelayUpdateInput updateDto,
        DelayWhereUniqueInput uniqueId
    )
    {
        var delay = new DelayDbModel
        {
            Id = uniqueId.Id,
            DeletionFlag = updateDto.DeletionFlag,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            LatePaymentDate = updateDto.LatePaymentDate,
            LatePaymentInterestAmount = updateDto.LatePaymentInterestAmount,
            LatePaymentInterestAmountExistingBeforeLatePayment =
                updateDto.LatePaymentInterestAmountExistingBeforeLatePayment,
            NoticeNumber = updateDto.NoticeNumber,
            NotificationDate = updateDto.NotificationDate,
            NumberOfTimesOfLatePayments = updateDto.NumberOfTimesOfLatePayments,
            OfficeCode = updateDto.OfficeCode,
            PaymentDeadline = updateDto.PaymentDeadline,
            PenaltyRate = updateDto.PenaltyRate,
            PreviousDueDate = updateDto.PreviousDueDate,
            PreviousNotificationDate = updateDto.PreviousNotificationDate,
            ServiceCode = updateDto.ServiceCode,
            TotalNoticeAmount = updateDto.TotalNoticeAmount,
            TotalPreviousNoticeAmount = updateDto.TotalPreviousNoticeAmount,
            UnadjustedLatePaymentInterestAmount = updateDto.UnadjustedLatePaymentInterestAmount
        };

        if (updateDto.CreatedAt != null)
        {
            delay.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            delay.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return delay;
    }
}

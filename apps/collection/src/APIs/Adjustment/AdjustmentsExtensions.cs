using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class AdjustmentsExtensions
{
    public static Adjustment ToDto(this AdjustmentDbModel model)
    {
        return new Adjustment
        {
            AdjustmentDate = model.AdjustmentDate,
            AdjustmentReasonContent = model.AdjustmentReasonContent,
            AttachedFileId = model.AttachedFileId,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            LatePaymentInterestAmount = model.LatePaymentInterestAmount,
            LatePaymentInterestAmountExistingBeforeLatePayment =
                model.LatePaymentInterestAmountExistingBeforeLatePayment,
            NoticeNumber = model.NoticeNumber,
            NumberOfAdjustments = model.NumberOfAdjustments,
            NumberOfLatePayments = model.NumberOfLatePayments,
            OfficeCode = model.OfficeCode,
            PreviousTotalNoticeAmount = model.PreviousTotalNoticeAmount,
            RegisteringPersonId = model.RegisteringPersonId,
            ServiceCode = model.ServiceCode,
            TotalNoticeAmount = model.TotalNoticeAmount,
            UnadjustedLatePaymentInterestAmount = model.UnadjustedLatePaymentInterestAmount,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static AdjustmentDbModel ToModel(
        this AdjustmentUpdateInput updateDto,
        AdjustmentWhereUniqueInput uniqueId
    )
    {
        var adjustment = new AdjustmentDbModel
        {
            Id = uniqueId.Id,
            AdjustmentDate = updateDto.AdjustmentDate,
            AdjustmentReasonContent = updateDto.AdjustmentReasonContent,
            AttachedFileId = updateDto.AttachedFileId,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            LatePaymentInterestAmount = updateDto.LatePaymentInterestAmount,
            LatePaymentInterestAmountExistingBeforeLatePayment =
                updateDto.LatePaymentInterestAmountExistingBeforeLatePayment,
            NoticeNumber = updateDto.NoticeNumber,
            NumberOfAdjustments = updateDto.NumberOfAdjustments,
            NumberOfLatePayments = updateDto.NumberOfLatePayments,
            OfficeCode = updateDto.OfficeCode,
            PreviousTotalNoticeAmount = updateDto.PreviousTotalNoticeAmount,
            RegisteringPersonId = updateDto.RegisteringPersonId,
            ServiceCode = updateDto.ServiceCode,
            TotalNoticeAmount = updateDto.TotalNoticeAmount,
            UnadjustedLatePaymentInterestAmount = updateDto.UnadjustedLatePaymentInterestAmount
        };

        if (updateDto.CreatedAt != null)
        {
            adjustment.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            adjustment.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return adjustment;
    }
}

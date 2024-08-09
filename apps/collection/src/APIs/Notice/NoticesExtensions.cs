using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class NoticesExtensions
{
    public static Notice ToDto(this NoticeDbModel model)
    {
        return new Notice
        {
            AmountOfOtherChargeableFees = model.AmountOfOtherChargeableFees,
            BondTypeCode = model.BondTypeCode,
            CancellationDate = model.CancellationDate,
            CancelledOn = model.CancelledOn,
            CollectedOn = model.CollectedOn,
            CreatedAt = model.CreatedAt,
            DeclarantCode = model.DeclarantCode,
            DeclarationNo = model.DeclarationNo,
            DeletionOn = model.DeletionOn,
            ExtendedDeadlineOn = model.ExtendedDeadlineOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FinancialManagerName = model.FinancialManagerName,
            FineAmount = model.FineAmount,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            LateDate = model.LateDate,
            LateInterestAdjustedYn = model.LateInterestAdjustedYn,
            LateInterestAmount = model.LateInterestAmount,
            LatePaymentOn = model.LatePaymentOn,
            NiuCategoryCode = model.NiuCategoryCode,
            NoticeCancellationReasonCode = model.NoticeCancellationReasonCode,
            NoticeNo = model.NoticeNo,
            NoticeProcessingStatusCode = model.NoticeProcessingStatusCode,
            NoticeTypeCode = model.NoticeTypeCode,
            NotificationDate = model.NotificationDate,
            OfficeCode = model.OfficeCode,
            OriginalNoticeNo = model.OriginalNoticeNo,
            PaymentDeadline = model.PaymentDeadline,
            PaymentNoticeIssuanceMoment = model.PaymentNoticeIssuanceMoment,
            ReceiptIssuedOn = model.ReceiptIssuedOn,
            ReferenceDate = model.ReferenceDate,
            ReferenceNo = model.ReferenceNo,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            RefundedAmount = model.RefundedAmount,
            SentYn = model.SentYn,
            ServiceCode = model.ServiceCode,
            StaggeredNoticeOn = model.StaggeredNoticeOn,
            StaggeredNoticeProcessingCode = model.StaggeredNoticeProcessingCode,
            TaxpayerIdentificationNo = model.TaxpayerIdentificationNo,
            TotalAmount = model.TotalAmount,
            TransmissionTypeCode = model.TransmissionTypeCode,
            UnadjustedLateInterestAmount = model.UnadjustedLateInterestAmount,
            UpdatedAt = model.UpdatedAt,
            UseOfRemovalCreditOn = model.UseOfRemovalCreditOn,
            VehicleOn = model.VehicleOn,
        };
    }

    public static NoticeDbModel ToModel(
        this NoticeUpdateInput updateDto,
        NoticeWhereUniqueInput uniqueId
    )
    {
        var notice = new NoticeDbModel
        {
            Id = uniqueId.Id,
            AmountOfOtherChargeableFees = updateDto.AmountOfOtherChargeableFees,
            BondTypeCode = updateDto.BondTypeCode,
            CancellationDate = updateDto.CancellationDate,
            CancelledOn = updateDto.CancelledOn,
            CollectedOn = updateDto.CollectedOn,
            DeclarantCode = updateDto.DeclarantCode,
            DeclarationNo = updateDto.DeclarationNo,
            DeletionOn = updateDto.DeletionOn,
            ExtendedDeadlineOn = updateDto.ExtendedDeadlineOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FinancialManagerName = updateDto.FinancialManagerName,
            FineAmount = updateDto.FineAmount,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            LateDate = updateDto.LateDate,
            LateInterestAdjustedYn = updateDto.LateInterestAdjustedYn,
            LateInterestAmount = updateDto.LateInterestAmount,
            LatePaymentOn = updateDto.LatePaymentOn,
            NiuCategoryCode = updateDto.NiuCategoryCode,
            NoticeCancellationReasonCode = updateDto.NoticeCancellationReasonCode,
            NoticeNo = updateDto.NoticeNo,
            NoticeProcessingStatusCode = updateDto.NoticeProcessingStatusCode,
            NoticeTypeCode = updateDto.NoticeTypeCode,
            NotificationDate = updateDto.NotificationDate,
            OfficeCode = updateDto.OfficeCode,
            OriginalNoticeNo = updateDto.OriginalNoticeNo,
            PaymentDeadline = updateDto.PaymentDeadline,
            PaymentNoticeIssuanceMoment = updateDto.PaymentNoticeIssuanceMoment,
            ReceiptIssuedOn = updateDto.ReceiptIssuedOn,
            ReferenceDate = updateDto.ReferenceDate,
            ReferenceNo = updateDto.ReferenceNo,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            RefundedAmount = updateDto.RefundedAmount,
            SentYn = updateDto.SentYn,
            ServiceCode = updateDto.ServiceCode,
            StaggeredNoticeOn = updateDto.StaggeredNoticeOn,
            StaggeredNoticeProcessingCode = updateDto.StaggeredNoticeProcessingCode,
            TaxpayerIdentificationNo = updateDto.TaxpayerIdentificationNo,
            TotalAmount = updateDto.TotalAmount,
            TransmissionTypeCode = updateDto.TransmissionTypeCode,
            UnadjustedLateInterestAmount = updateDto.UnadjustedLateInterestAmount,
            UseOfRemovalCreditOn = updateDto.UseOfRemovalCreditOn,
            VehicleOn = updateDto.VehicleOn
        };

        if (updateDto.CreatedAt != null)
        {
            notice.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            notice.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return notice;
    }
}

using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class ReceptionsExtensions
{
    public static Reception ToDto(this ReceptionDbModel model)
    {
        return new Reception
        {
            AuthorizationCode = model.AuthorizationCode,
            CardNo = model.CardNo,
            CardValidityDuration = model.CardValidityDuration,
            CardholderName = model.CardholderName,
            CollectionNo = model.CollectionNo,
            ConnectionIp = model.ConnectionIp,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            ErrorMessageContent = model.ErrorMessageContent,
            ErrorsErrorCode = model.ErrorsErrorCode,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            LinkingParameterContent = model.LinkingParameterContent,
            NoticeNo = model.NoticeNo,
            OrderIdentifier = model.OrderIdentifier,
            OrderNumber = model.OrderNumber,
            OrderStatusParameter = model.OrderStatusParameter,
            PaymentDateAndTime = model.PaymentDateAndTime,
            ProcessingStatusCode = model.ProcessingStatusCode,
            ProcessingStatusContent = model.ProcessingStatusContent,
            ThreeDigitCountryCode = model.ThreeDigitCountryCode,
            TotalNoticeAmount = model.TotalNoticeAmount,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ReceptionDbModel ToModel(
        this ReceptionUpdateInput updateDto,
        ReceptionWhereUniqueInput uniqueId
    )
    {
        var reception = new ReceptionDbModel
        {
            Id = uniqueId.Id,
            AuthorizationCode = updateDto.AuthorizationCode,
            CardNo = updateDto.CardNo,
            CardValidityDuration = updateDto.CardValidityDuration,
            CardholderName = updateDto.CardholderName,
            CollectionNo = updateDto.CollectionNo,
            ConnectionIp = updateDto.ConnectionIp,
            DeletionOn = updateDto.DeletionOn,
            ErrorMessageContent = updateDto.ErrorMessageContent,
            ErrorsErrorCode = updateDto.ErrorsErrorCode,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            LinkingParameterContent = updateDto.LinkingParameterContent,
            NoticeNo = updateDto.NoticeNo,
            OrderIdentifier = updateDto.OrderIdentifier,
            OrderNumber = updateDto.OrderNumber,
            OrderStatusParameter = updateDto.OrderStatusParameter,
            PaymentDateAndTime = updateDto.PaymentDateAndTime,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            ProcessingStatusContent = updateDto.ProcessingStatusContent,
            ThreeDigitCountryCode = updateDto.ThreeDigitCountryCode,
            TotalNoticeAmount = updateDto.TotalNoticeAmount
        };

        if (updateDto.CreatedAt != null)
        {
            reception.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            reception.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return reception;
    }
}

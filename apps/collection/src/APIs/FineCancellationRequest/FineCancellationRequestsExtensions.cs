using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class FineCancellationRequestsExtensions
{
    public static FineCancellationRequest ToDto(this FineCancellationRequestDbModel model)
    {
        return new FineCancellationRequest
        {
            ApprovalId = model.ApprovalId,
            AttachmentId = model.AttachmentId,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FineCancellationReasonContent = model.FineCancellationReasonContent,
            FineCancellationRequestNo = model.FineCancellationRequestNo,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NoticeNo = model.NoticeNo,
            OfficeCode = model.OfficeCode,
            RequestDate = model.RequestDate,
            RequestingPersonId = model.RequestingPersonId,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static FineCancellationRequestDbModel ToModel(
        this FineCancellationRequestUpdateInput updateDto,
        FineCancellationRequestWhereUniqueInput uniqueId
    )
    {
        var fineCancellationRequest = new FineCancellationRequestDbModel
        {
            Id = uniqueId.Id,
            ApprovalId = updateDto.ApprovalId,
            AttachmentId = updateDto.AttachmentId,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FineCancellationReasonContent = updateDto.FineCancellationReasonContent,
            FineCancellationRequestNo = updateDto.FineCancellationRequestNo,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NoticeNo = updateDto.NoticeNo,
            OfficeCode = updateDto.OfficeCode,
            RequestDate = updateDto.RequestDate,
            RequestingPersonId = updateDto.RequestingPersonId,
            ServiceCode = updateDto.ServiceCode
        };

        if (updateDto.CreatedAt != null) fineCancellationRequest.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) fineCancellationRequest.UpdatedAt = updateDto.UpdatedAt.Value;

        return fineCancellationRequest;
    }
}

using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class VariousRequestsExtensions
{
    public static VariousRequest ToDto(this VariousRequestDbModel model)
    {
        return new VariousRequest
        {
            AttachmentFileId = model.AttachmentFileId,
            CodeJustificationDescription = model.CodeJustificationDescription,
            CreatedAt = model.CreatedAt,
            DeclarantCode = model.DeclarantCode,
            DeclarantName = model.DeclarantName,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            OfficeCode = model.OfficeCode,
            ProcessingDate = model.ProcessingDate,
            ProcessingResult = model.ProcessingResult,
            ProcessingStatusCode = model.ProcessingStatusCode,
            ReceiverId = model.ReceiverId,
            ReferenceNo = model.ReferenceNo,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            RequestDate = model.RequestDate,
            RequestNo = model.RequestNo,
            RequestTypeCode = model.RequestTypeCode,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static VariousRequestDbModel ToModel(
        this VariousRequestUpdateInput updateDto,
        VariousRequestWhereUniqueInput uniqueId
    )
    {
        var variousRequest = new VariousRequestDbModel
        {
            Id = uniqueId.Id,
            AttachmentFileId = updateDto.AttachmentFileId,
            CodeJustificationDescription = updateDto.CodeJustificationDescription,
            DeclarantCode = updateDto.DeclarantCode,
            DeclarantName = updateDto.DeclarantName,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            OfficeCode = updateDto.OfficeCode,
            ProcessingDate = updateDto.ProcessingDate,
            ProcessingResult = updateDto.ProcessingResult,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            ReceiverId = updateDto.ReceiverId,
            ReferenceNo = updateDto.ReferenceNo,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            RequestDate = updateDto.RequestDate,
            RequestNo = updateDto.RequestNo,
            RequestTypeCode = updateDto.RequestTypeCode,
            ServiceCode = updateDto.ServiceCode
        };

        if (updateDto.CreatedAt != null) variousRequest.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) variousRequest.UpdatedAt = updateDto.UpdatedAt.Value;

        return variousRequest;
    }
}

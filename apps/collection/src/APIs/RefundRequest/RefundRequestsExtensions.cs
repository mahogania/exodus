using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class RefundRequestsExtensions
{
    public static RefundRequest ToDto(this RefundRequestDbModel model)
    {
        return new RefundRequest
        {
            AccountCode = model.AccountCode,
            ApprovalId = model.ApprovalId,
            AttachedFileId = model.AttachedFileId,
            CreatedAt = model.CreatedAt,
            DeletionFlag = model.DeletionFlag,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FinancialOfficerSName = model.FinancialOfficerSName,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NiuCategoryCode = model.NiuCategoryCode,
            OfficeCode = model.OfficeCode,
            PersonRequestingId = model.PersonRequestingId,
            ProcessingStatusCode = model.ProcessingStatusCode,
            ReceiptNumber = model.ReceiptNumber,
            ReferenceNumber = model.ReferenceNumber,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            RefundRequestNumber = model.RefundRequestNumber,
            RefundRequestedOn = model.RefundRequestedOn,
            RequestDate = model.RequestDate,
            ServiceCode = model.ServiceCode,
            TaxpayerIdentificationNumber = model.TaxpayerIdentificationNumber,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static RefundRequestDbModel ToModel(
        this RefundRequestUpdateInput updateDto,
        RefundRequestWhereUniqueInput uniqueId
    )
    {
        var refundRequest = new RefundRequestDbModel
        {
            Id = uniqueId.Id,
            AccountCode = updateDto.AccountCode,
            ApprovalId = updateDto.ApprovalId,
            AttachedFileId = updateDto.AttachedFileId,
            DeletionFlag = updateDto.DeletionFlag,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FinancialOfficerSName = updateDto.FinancialOfficerSName,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NiuCategoryCode = updateDto.NiuCategoryCode,
            OfficeCode = updateDto.OfficeCode,
            PersonRequestingId = updateDto.PersonRequestingId,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            ReceiptNumber = updateDto.ReceiptNumber,
            ReferenceNumber = updateDto.ReferenceNumber,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            RefundRequestNumber = updateDto.RefundRequestNumber,
            RefundRequestedOn = updateDto.RefundRequestedOn,
            RequestDate = updateDto.RequestDate,
            ServiceCode = updateDto.ServiceCode,
            TaxpayerIdentificationNumber = updateDto.TaxpayerIdentificationNumber
        };

        if (updateDto.CreatedAt != null) refundRequest.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) refundRequest.UpdatedAt = updateDto.UpdatedAt.Value;

        return refundRequest;
    }
}

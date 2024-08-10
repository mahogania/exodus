using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class FinesExtensions
{
    public static Fine ToDto(this FineDbModel model)
    {
        return new Fine
        {
            AttachmentId = model.AttachmentId,
            CreatedAt = model.CreatedAt,
            DeclarantCode = model.DeclarantCode,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FinancialManagerName = model.FinancialManagerName,
            FineAmount = model.FineAmount,
            FineAmountInEur = model.FineAmountInEur,
            FineAmountInUsd = model.FineAmountInUsd,
            FineCancellationDate = model.FineCancellationDate,
            FineCancellationOfficerId = model.FineCancellationOfficerId,
            FineCancellationReasonContent = model.FineCancellationReasonContent,
            FineCancellationRequestNo = model.FineCancellationRequestNo,
            FineImpositionRequestNo = model.FineImpositionRequestNo,
            FineRegistrationReasonContent = model.FineRegistrationReasonContent,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NiuCategoryCode = model.NiuCategoryCode,
            NiuCategoryName = model.NiuCategoryName,
            NoticeNo = model.NoticeNo,
            NotificationRequiredOn = model.NotificationRequiredOn,
            OfficeCode = model.OfficeCode,
            ReferenceDate = model.ReferenceDate,
            ReferenceNo = model.ReferenceNo,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = model.ReferenceNumberTypeName,
            RegisteringPersonId = model.RegisteringPersonId,
            RegistrationDate = model.RegistrationDate,
            ServiceCode = model.ServiceCode,
            TaxpayerIdentificationNo = model.TaxpayerIdentificationNo,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static FineDbModel ToModel(this FineUpdateInput updateDto, FineWhereUniqueInput uniqueId)
    {
        var fine = new FineDbModel
        {
            Id = uniqueId.Id,
            AttachmentId = updateDto.AttachmentId,
            DeclarantCode = updateDto.DeclarantCode,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FinancialManagerName = updateDto.FinancialManagerName,
            FineAmount = updateDto.FineAmount,
            FineAmountInEur = updateDto.FineAmountInEur,
            FineAmountInUsd = updateDto.FineAmountInUsd,
            FineCancellationDate = updateDto.FineCancellationDate,
            FineCancellationOfficerId = updateDto.FineCancellationOfficerId,
            FineCancellationReasonContent = updateDto.FineCancellationReasonContent,
            FineCancellationRequestNo = updateDto.FineCancellationRequestNo,
            FineImpositionRequestNo = updateDto.FineImpositionRequestNo,
            FineRegistrationReasonContent = updateDto.FineRegistrationReasonContent,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NiuCategoryCode = updateDto.NiuCategoryCode,
            NiuCategoryName = updateDto.NiuCategoryName,
            NoticeNo = updateDto.NoticeNo,
            NotificationRequiredOn = updateDto.NotificationRequiredOn,
            OfficeCode = updateDto.OfficeCode,
            ReferenceDate = updateDto.ReferenceDate,
            ReferenceNo = updateDto.ReferenceNo,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = updateDto.ReferenceNumberTypeName,
            RegisteringPersonId = updateDto.RegisteringPersonId,
            RegistrationDate = updateDto.RegistrationDate,
            ServiceCode = updateDto.ServiceCode,
            TaxpayerIdentificationNo = updateDto.TaxpayerIdentificationNo
        };

        if (updateDto.CreatedAt != null) fine.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) fine.UpdatedAt = updateDto.UpdatedAt.Value;

        return fine;
    }
}

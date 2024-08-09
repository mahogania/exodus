using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class ClaimedFinesExtensions
{
    public static ClaimedFine ToDto(this ClaimedFineDbModel model)
    {
        return new ClaimedFine
        {
            AcceptedByTaxpayerOn = model.AcceptedByTaxpayerOn,
            ApprovalId = model.ApprovalId,
            AttachedFileId = model.AttachedFileId,
            CreatedAt = model.CreatedAt,
            DeclarantCode = model.DeclarantCode,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FinancialOfficerName = model.FinancialOfficerName,
            FineAmount = model.FineAmount,
            FineAmountInEur = model.FineAmountInEur,
            FineAmountInUsd = model.FineAmountInUsd,
            FineImpositionRequestNumber = model.FineImpositionRequestNumber,
            FineRegistrationReasonContent = model.FineRegistrationReasonContent,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NotificationRequiredOn = model.NotificationRequiredOn,
            OfficeCode = model.OfficeCode,
            OpinionRegisteredByTaxpayerOn = model.OpinionRegisteredByTaxpayerOn,
            ReferenceDate = model.ReferenceDate,
            ReferenceNumber = model.ReferenceNumber,
            ReferenceNumberTypeCode = model.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = model.ReferenceNumberTypeName,
            RequestDate = model.RequestDate,
            RequestingPersonId = model.RequestingPersonId,
            ServiceCode = model.ServiceCode,
            TaxpayerAcceptanceMoment = model.TaxpayerAcceptanceMoment,
            TaxpayerIdentificationNumber = model.TaxpayerIdentificationNumber,
            TinCategoryCode = model.TinCategoryCode,
            TinCategoryName = model.TinCategoryName,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ClaimedFineDbModel ToModel(
        this ClaimedFineUpdateInput updateDto,
        ClaimedFineWhereUniqueInput uniqueId
    )
    {
        var claimedFine = new ClaimedFineDbModel
        {
            Id = uniqueId.Id,
            AcceptedByTaxpayerOn = updateDto.AcceptedByTaxpayerOn,
            ApprovalId = updateDto.ApprovalId,
            AttachedFileId = updateDto.AttachedFileId,
            DeclarantCode = updateDto.DeclarantCode,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FinancialOfficerName = updateDto.FinancialOfficerName,
            FineAmount = updateDto.FineAmount,
            FineAmountInEur = updateDto.FineAmountInEur,
            FineAmountInUsd = updateDto.FineAmountInUsd,
            FineImpositionRequestNumber = updateDto.FineImpositionRequestNumber,
            FineRegistrationReasonContent = updateDto.FineRegistrationReasonContent,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NotificationRequiredOn = updateDto.NotificationRequiredOn,
            OfficeCode = updateDto.OfficeCode,
            OpinionRegisteredByTaxpayerOn = updateDto.OpinionRegisteredByTaxpayerOn,
            ReferenceDate = updateDto.ReferenceDate,
            ReferenceNumber = updateDto.ReferenceNumber,
            ReferenceNumberTypeCode = updateDto.ReferenceNumberTypeCode,
            ReferenceNumberTypeName = updateDto.ReferenceNumberTypeName,
            RequestDate = updateDto.RequestDate,
            RequestingPersonId = updateDto.RequestingPersonId,
            ServiceCode = updateDto.ServiceCode,
            TaxpayerAcceptanceMoment = updateDto.TaxpayerAcceptanceMoment,
            TaxpayerIdentificationNumber = updateDto.TaxpayerIdentificationNumber,
            TinCategoryCode = updateDto.TinCategoryCode,
            TinCategoryName = updateDto.TinCategoryName
        };

        if (updateDto.CreatedAt != null)
        {
            claimedFine.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            claimedFine.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return claimedFine;
    }
}

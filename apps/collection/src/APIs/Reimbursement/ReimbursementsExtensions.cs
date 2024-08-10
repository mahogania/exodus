using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class ReimbursementsExtensions
{
    public static Reimbursement ToDto(this ReimbursementDbModel model)
    {
        return new Reimbursement
        {
            AttachmentFileId = model.AttachmentFileId,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            OfficeCode = model.OfficeCode,
            ReceiverSOpinion = model.ReceiverSOpinion,
            RegistrationPersonIdentifier = model.RegistrationPersonIdentifier,
            ReimbursedAmount = model.ReimbursedAmount,
            ReimbursementDate = model.ReimbursementDate,
            ReimbursementDecisionType = model.ReimbursementDecisionType,
            ReimbursementNo = model.ReimbursementNo,
            ReimbursementReasonContent = model.ReimbursementReasonContent,
            ReimbursementRequestNo = model.ReimbursementRequestNo,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static ReimbursementDbModel ToModel(
        this ReimbursementUpdateInput updateDto,
        ReimbursementWhereUniqueInput uniqueId
    )
    {
        var reimbursement = new ReimbursementDbModel
        {
            Id = uniqueId.Id,
            AttachmentFileId = updateDto.AttachmentFileId,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            OfficeCode = updateDto.OfficeCode,
            ReceiverSOpinion = updateDto.ReceiverSOpinion,
            RegistrationPersonIdentifier = updateDto.RegistrationPersonIdentifier,
            ReimbursedAmount = updateDto.ReimbursedAmount,
            ReimbursementDate = updateDto.ReimbursementDate,
            ReimbursementDecisionType = updateDto.ReimbursementDecisionType,
            ReimbursementNo = updateDto.ReimbursementNo,
            ReimbursementReasonContent = updateDto.ReimbursementReasonContent,
            ReimbursementRequestNo = updateDto.ReimbursementRequestNo
        };

        if (updateDto.CreatedAt != null) reimbursement.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) reimbursement.UpdatedAt = updateDto.UpdatedAt.Value;

        return reimbursement;
    }
}

using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class AppealsExtensions
{
    public static Appeal ToDto(this AppealDbModel model)
    {
        return new Appeal
        {
            AttachedFileId = model.AttachedFileId,
            CreatedAt = model.CreatedAt,
            DeletionFlag = model.DeletionFlag,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FineImpositionRequestNumber = model.FineImpositionRequestNumber,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NumberOfOpinions = model.NumberOfOpinions,
            OfficeCode = model.OfficeCode,
            OpinionContent = model.OpinionContent,
            RegistrationDateAndTime = model.RegistrationDateAndTime,
            ResponseContent = model.ResponseContent,
            ServiceCode = model.ServiceCode,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static AppealDbModel ToModel(
        this AppealUpdateInput updateDto,
        AppealWhereUniqueInput uniqueId
    )
    {
        var appeal = new AppealDbModel
        {
            Id = uniqueId.Id,
            AttachedFileId = updateDto.AttachedFileId,
            DeletionFlag = updateDto.DeletionFlag,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FineImpositionRequestNumber = updateDto.FineImpositionRequestNumber,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NumberOfOpinions = updateDto.NumberOfOpinions,
            OfficeCode = updateDto.OfficeCode,
            OpinionContent = updateDto.OpinionContent,
            RegistrationDateAndTime = updateDto.RegistrationDateAndTime,
            ResponseContent = updateDto.ResponseContent,
            ServiceCode = updateDto.ServiceCode
        };

        if (updateDto.CreatedAt != null) appeal.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) appeal.UpdatedAt = updateDto.UpdatedAt.Value;

        return appeal;
    }
}

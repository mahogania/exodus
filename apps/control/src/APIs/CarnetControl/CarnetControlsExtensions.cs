using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CarnetControlsExtensions
{
    public static CarnetControl ToDto(this CarnetControlDbModel model)
    {
        return new CarnetControl
        {
            AtaCarnetManagementNumber = model.AtaCarnetManagementNumber,
            AttachedFileId = model.AttachedFileId,
            AuthorizationDate = model.AuthorizationDate,
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = model.DateAndTimeOfInitialRecord,
            DeletedOn = model.DeletedOn,
            FinalModifierId = model.FinalModifierId,
            GrantedDeadlineEndDate = model.GrantedDeadlineEndDate,
            Id = model.Id,
            InitialRecorderId = model.InitialRecorderId,
            ProcessingStatusCode = model.ProcessingStatusCode,
            UpdatedAt = model.UpdatedAt,
            VerificationResultContent = model.VerificationResultContent,
        };
    }

    public static CarnetControlDbModel ToModel(
        this CarnetControlUpdateInput updateDto,
        CarnetControlWhereUniqueInput uniqueId
    )
    {
        var carnetControl = new CarnetControlDbModel
        {
            Id = uniqueId.Id,
            AtaCarnetManagementNumber = updateDto.AtaCarnetManagementNumber,
            AttachedFileId = updateDto.AttachedFileId,
            AuthorizationDate = updateDto.AuthorizationDate,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = updateDto.DateAndTimeOfInitialRecord,
            DeletedOn = updateDto.DeletedOn,
            FinalModifierId = updateDto.FinalModifierId,
            GrantedDeadlineEndDate = updateDto.GrantedDeadlineEndDate,
            InitialRecorderId = updateDto.InitialRecorderId,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            VerificationResultContent = updateDto.VerificationResultContent
        };

        if (updateDto.CreatedAt != null)
        {
            carnetControl.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            carnetControl.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return carnetControl;
    }
}

using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonAtaCarnetControlsExtensions
{
    public static CommonAtaCarnetControl ToDto(this CommonAtaCarnetControlDbModel model)
    {
        return new CommonAtaCarnetControl
        {
            AttachmentFileId = model.AttachmentFileId,
            AuthorizationDate = model.AuthorizationDate,
            CarnetNumber = model.CarnetNumber,
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            DeletedOn = model.DeletedOn,
            FirstRecordDateAndTime = model.FirstRecordDateAndTime,
            FirstRecorderId = model.FirstRecorderId,
            GrantedDeadline = model.GrantedDeadline,
            Id = model.Id,
            LastModificationDateAndTime = model.LastModificationDateAndTime,
            LastModifierId = model.LastModifierId,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            ProcessingStatusCode = model.ProcessingStatusCode,
            UpdatedAt = model.UpdatedAt,
            VerificationResultContent = model.VerificationResultContent,
        };
    }

    public static CommonAtaCarnetControlDbModel ToModel(
        this CommonAtaCarnetControlUpdateInput updateDto,
        CommonAtaCarnetControlWhereUniqueInput uniqueId
    )
    {
        var commonAtaCarnetControl = new CommonAtaCarnetControlDbModel
        {
            Id = uniqueId.Id,
            AttachmentFileId = updateDto.AttachmentFileId,
            AuthorizationDate = updateDto.AuthorizationDate,
            CarnetNumber = updateDto.CarnetNumber,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            DeletedOn = updateDto.DeletedOn,
            FirstRecordDateAndTime = updateDto.FirstRecordDateAndTime,
            FirstRecorderId = updateDto.FirstRecorderId,
            GrantedDeadline = updateDto.GrantedDeadline,
            LastModificationDateAndTime = updateDto.LastModificationDateAndTime,
            LastModifierId = updateDto.LastModifierId,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            VerificationResultContent = updateDto.VerificationResultContent
        };

        if (updateDto.CreatedAt != null)
        {
            commonAtaCarnetControl.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            commonAtaCarnetControl.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return commonAtaCarnetControl;
    }
}

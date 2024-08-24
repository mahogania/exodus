using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class CommonAtaCarnetControlAltsExtensions
{
    public static CommonAtaCarnetControlAlt ToDto(this CommonAtaCarnetControlAltDbModel model)
    {
        return new CommonAtaCarnetControlAlt
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

    public static CommonAtaCarnetControlAltDbModel ToModel(
        this CommonAtaCarnetControlAltUpdateInput updateDto,
        CommonAtaCarnetControlAltWhereUniqueInput uniqueId
    )
    {
        var commonAtaCarnetControlAlt = new CommonAtaCarnetControlAltDbModel
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
            commonAtaCarnetControlAlt.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            commonAtaCarnetControlAlt.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return commonAtaCarnetControlAlt;
    }
}

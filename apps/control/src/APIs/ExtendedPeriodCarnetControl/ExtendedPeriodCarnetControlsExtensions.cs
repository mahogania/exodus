using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ExtendedPeriodCarnetControlsExtensions
{
    public static ExtendedPeriodCarnetControl ToDto(this ExtendedPeriodCarnetControlDbModel model)
    {
        return new ExtendedPeriodCarnetControl
        {
            AttachmentFileId = model.AttachmentFileId,
            AuthorizationDate = model.AuthorizationDate,
            CarnetNumber = model.CarnetNumber,
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            DeletedOn = model.DeletedOn,
            ExtendedPeriodCarnetRequest = model.ExtendedPeriodCarnetRequestId,
            FirstRecordDateAndTime = model.FirstRecordDateAndTime,
            FirstRecorderId = model.FirstRecorderId,
            Id = model.Id,
            LastModificationDateAndTime = model.LastModificationDateAndTime,
            LastModifierId = model.LastModifierId,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            ProcessingStatusCode = model.ProcessingStatusCode,
            SequenceNumber = model.SequenceNumber,
            UpdatedAt = model.UpdatedAt,
            VerificationResultContent = model.VerificationResultContent,
        };
    }

    public static ExtendedPeriodCarnetControlDbModel ToModel(
        this ExtendedPeriodCarnetControlUpdateInput updateDto,
        ExtendedPeriodCarnetControlWhereUniqueInput uniqueId
    )
    {
        var extendedPeriodCarnetControl = new ExtendedPeriodCarnetControlDbModel
        {
            Id = uniqueId.Id,
            AttachmentFileId = updateDto.AttachmentFileId,
            AuthorizationDate = updateDto.AuthorizationDate,
            CarnetNumber = updateDto.CarnetNumber,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            DeletedOn = updateDto.DeletedOn,
            FirstRecordDateAndTime = updateDto.FirstRecordDateAndTime,
            FirstRecorderId = updateDto.FirstRecorderId,
            LastModificationDateAndTime = updateDto.LastModificationDateAndTime,
            LastModifierId = updateDto.LastModifierId,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            SequenceNumber = updateDto.SequenceNumber,
            VerificationResultContent = updateDto.VerificationResultContent
        };

        if (updateDto.CreatedAt != null)
        {
            extendedPeriodCarnetControl.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.ExtendedPeriodCarnetRequest != null)
        {
            extendedPeriodCarnetControl.ExtendedPeriodCarnetRequestId =
                updateDto.ExtendedPeriodCarnetRequest;
        }
        if (updateDto.UpdatedAt != null)
        {
            extendedPeriodCarnetControl.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return extendedPeriodCarnetControl;
    }
}

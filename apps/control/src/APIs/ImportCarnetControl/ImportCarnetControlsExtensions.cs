using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ImportCarnetControlsExtensions
{
    public static ImportCarnetControl ToDto(this ImportCarnetControlDbModel model)
    {
        return new ImportCarnetControl
        {
            AttachmentFileId = model.AttachmentFileId,
            AuthorizationDate = model.AuthorizationDate,
            CarnetNumber = model.CarnetNumber,
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            DeletedOn = model.DeletedOn,
            FirstRecordDateAndTime = model.FirstRecordDateAndTime,
            FirstRecorderId = model.FirstRecorderId,
            Id = model.Id,
            ImportCarnetRequest = model.ImportCarnetRequest?.ToDto(),
            LastModificationDateAndTime = model.LastModificationDateAndTime,
            LastModifierId = model.LastModifierId,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            OtherContents = model.OtherContents,
            ProcessingStatusCode = model.ProcessingStatusCode,
            ReExportationDate = model.ReExportationDate,
            ReferenceNo = model.ReferenceNo,
            TemporarilyImportedArticles = model.TemporarilyImportedArticles,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ImportCarnetControlDbModel ToModel(
        this ImportCarnetControlUpdateInput updateDto,
        ImportCarnetControlWhereUniqueInput uniqueId
    )
    {
        var importCarnetControl = new ImportCarnetControlDbModel
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
            OtherContents = updateDto.OtherContents,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            ReExportationDate = updateDto.ReExportationDate,
            ReferenceNo = updateDto.ReferenceNo,
            TemporarilyImportedArticles = updateDto.TemporarilyImportedArticles
        };

        if (updateDto.CreatedAt != null)
        {
            importCarnetControl.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            importCarnetControl.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return importCarnetControl;
    }
}

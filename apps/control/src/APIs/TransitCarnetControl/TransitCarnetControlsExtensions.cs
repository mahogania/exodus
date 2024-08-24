using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class TransitCarnetControlsExtensions
{
    public static TransitCarnetControl ToDto(this TransitCarnetControlDbModel model)
    {
        return new TransitCarnetControl
        {
            ArrivalAuthorizationDate = model.ArrivalAuthorizationDate,
            ArrivalDate = model.ArrivalDate,
            ArticlesInTransit = model.ArticlesInTransit,
            AttachmentFileId = model.AttachmentFileId,
            AuthorizationDate = model.AuthorizationDate,
            CarnetNumber = model.CarnetNumber,
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            CustomsSealCode = model.CustomsSealCode,
            DeletedOn = model.DeletedOn,
            DestinationOffice = model.DestinationOffice,
            FirstRecordDateAndTime = model.FirstRecordDateAndTime,
            FirstRecorderId = model.FirstRecorderId,
            Id = model.Id,
            LastModificationDateAndTime = model.LastModificationDateAndTime,
            LastModifierId = model.LastModifierId,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            OtherContents = model.OtherContents,
            ProcessingStatusCode = model.ProcessingStatusCode,
            ReExportationDate = model.ReExportationDate,
            ReExportedArticles = model.ReExportedArticles,
            ReferenceNo = model.ReferenceNo,
            TransitCarnetRequests = model.TransitCarnetRequests?.Select(x => x.Id).ToList(),
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static TransitCarnetControlDbModel ToModel(
        this TransitCarnetControlUpdateInput updateDto,
        TransitCarnetControlWhereUniqueInput uniqueId
    )
    {
        var transitCarnetControl = new TransitCarnetControlDbModel
        {
            Id = uniqueId.Id,
            ArrivalAuthorizationDate = updateDto.ArrivalAuthorizationDate,
            ArrivalDate = updateDto.ArrivalDate,
            ArticlesInTransit = updateDto.ArticlesInTransit,
            AttachmentFileId = updateDto.AttachmentFileId,
            AuthorizationDate = updateDto.AuthorizationDate,
            CarnetNumber = updateDto.CarnetNumber,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            CustomsSealCode = updateDto.CustomsSealCode,
            DeletedOn = updateDto.DeletedOn,
            DestinationOffice = updateDto.DestinationOffice,
            FirstRecordDateAndTime = updateDto.FirstRecordDateAndTime,
            FirstRecorderId = updateDto.FirstRecorderId,
            LastModificationDateAndTime = updateDto.LastModificationDateAndTime,
            LastModifierId = updateDto.LastModifierId,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            OtherContents = updateDto.OtherContents,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            ReExportationDate = updateDto.ReExportationDate,
            ReExportedArticles = updateDto.ReExportedArticles,
            ReferenceNo = updateDto.ReferenceNo
        };

        if (updateDto.CreatedAt != null)
        {
            transitCarnetControl.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            transitCarnetControl.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return transitCarnetControl;
    }
}

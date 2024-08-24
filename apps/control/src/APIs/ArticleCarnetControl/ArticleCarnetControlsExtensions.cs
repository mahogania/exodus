using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ArticleCarnetControlsExtensions
{
    public static ArticleCarnetControl ToDto(this ArticleCarnetControlDbModel model)
    {
        return new ArticleCarnetControl
        {
            ArticleNumber = model.ArticleNumber,
            AttachmentFileId = model.AttachmentFileId,
            AuthorizationDate = model.AuthorizationDate,
            CarnetNumber = model.CarnetNumber,
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
            CustomsNote = model.CustomsNote,
            DeletedOn = model.DeletedOn,
            FirstRecordDateAndTime = model.FirstRecordDateAndTime,
            FirstRecorderId = model.FirstRecorderId,
            Id = model.Id,
            LastModificationDateAndTime = model.LastModificationDateAndTime,
            LastModifierId = model.LastModifierId,
            ManagementNumberOfCarnet = model.ManagementNumberOfCarnet,
            OperationTypeCode = model.OperationTypeCode,
            ProcessingStatusCode = model.ProcessingStatusCode,
            ReferenceNo = model.ReferenceNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ArticleCarnetControlDbModel ToModel(
        this ArticleCarnetControlUpdateInput updateDto,
        ArticleCarnetControlWhereUniqueInput uniqueId
    )
    {
        var articleCarnetControl = new ArticleCarnetControlDbModel
        {
            Id = uniqueId.Id,
            ArticleNumber = updateDto.ArticleNumber,
            AttachmentFileId = updateDto.AttachmentFileId,
            AuthorizationDate = updateDto.AuthorizationDate,
            CarnetNumber = updateDto.CarnetNumber,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            CustomsNote = updateDto.CustomsNote,
            DeletedOn = updateDto.DeletedOn,
            FirstRecordDateAndTime = updateDto.FirstRecordDateAndTime,
            FirstRecorderId = updateDto.FirstRecorderId,
            LastModificationDateAndTime = updateDto.LastModificationDateAndTime,
            LastModifierId = updateDto.LastModifierId,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            OperationTypeCode = updateDto.OperationTypeCode,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            ReferenceNo = updateDto.ReferenceNo
        };

        if (updateDto.CreatedAt != null)
        {
            articleCarnetControl.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            articleCarnetControl.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return articleCarnetControl;
    }
}

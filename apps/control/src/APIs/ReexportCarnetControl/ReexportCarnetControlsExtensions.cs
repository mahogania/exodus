using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ReexportCarnetControlsExtensions
{
    public static ReexportCarnetControl ToDto(this ReexportCarnetControlDbModel model)
    {
        return new ReexportCarnetControl
        {
            ActionsAgainstArticlesThatCannotBeReexported_1 =
                model.ActionsAgainstArticlesThatCannotBeReexported_1,
            ActionsAgainstArticlesThatCannotBeReexported_2 =
                model.ActionsAgainstArticlesThatCannotBeReexported_2,
            AttachmentFileId = model.AttachmentFileId,
            AuthorizationDate = model.AuthorizationDate,
            CarnetNumber = model.CarnetNumber,
            CarnetTypeCode = model.CarnetTypeCode,
            CreatedAt = model.CreatedAt,
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
            ReexportedArticles = model.ReexportedArticles,
            ReferenceNo = model.ReferenceNo,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ReexportCarnetControlDbModel ToModel(
        this ReexportCarnetControlUpdateInput updateDto,
        ReexportCarnetControlWhereUniqueInput uniqueId
    )
    {
        var reexportCarnetControl = new ReexportCarnetControlDbModel
        {
            Id = uniqueId.Id,
            ActionsAgainstArticlesThatCannotBeReexported_1 =
                updateDto.ActionsAgainstArticlesThatCannotBeReexported_1,
            ActionsAgainstArticlesThatCannotBeReexported_2 =
                updateDto.ActionsAgainstArticlesThatCannotBeReexported_2,
            AttachmentFileId = updateDto.AttachmentFileId,
            AuthorizationDate = updateDto.AuthorizationDate,
            CarnetNumber = updateDto.CarnetNumber,
            CarnetTypeCode = updateDto.CarnetTypeCode,
            DeletedOn = updateDto.DeletedOn,
            DestinationOffice = updateDto.DestinationOffice,
            FirstRecordDateAndTime = updateDto.FirstRecordDateAndTime,
            FirstRecorderId = updateDto.FirstRecorderId,
            LastModificationDateAndTime = updateDto.LastModificationDateAndTime,
            LastModifierId = updateDto.LastModifierId,
            ManagementNumberOfCarnet = updateDto.ManagementNumberOfCarnet,
            OtherContents = updateDto.OtherContents,
            ProcessingStatusCode = updateDto.ProcessingStatusCode,
            ReexportedArticles = updateDto.ReexportedArticles,
            ReferenceNo = updateDto.ReferenceNo
        };

        if (updateDto.CreatedAt != null)
        {
            reexportCarnetControl.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            reexportCarnetControl.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return reexportCarnetControl;
    }
}

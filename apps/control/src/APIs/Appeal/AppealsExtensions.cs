using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class AppealsExtensions
{
    public static Appeal ToDto(this AppealDbModel model)
    {
        return new Appeal
        {
            AppealContent = model.AppealContent,
            AttachedFileId = model.AttachedFileId,
            CommonVerifications = model.CommonVerifications?.Select(x => x.Id).ToList(),
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = model.DateAndTimeOfInitialRecord,
            DeletedOn = model.DeletedOn,
            FinalModifierId = model.FinalModifierId,
            Id = model.Id,
            InitialRecorderId = model.InitialRecorderId,
            UpdatedAt = model.UpdatedAt,
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
            AppealContent = updateDto.AppealContent,
            AttachedFileId = updateDto.AttachedFileId,
            DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
            DateAndTimeOfInitialRecord = updateDto.DateAndTimeOfInitialRecord,
            DeletedOn = updateDto.DeletedOn,
            FinalModifierId = updateDto.FinalModifierId,
            InitialRecorderId = updateDto.InitialRecorderId
        };

        if (updateDto.CreatedAt != null)
        {
            appeal.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            appeal.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return appeal;
    }
}

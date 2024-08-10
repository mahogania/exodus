using Collection.APIs.Dtos;
using Collection.Infrastructure.Models;

namespace Collection.APIs.Extensions;

public static class NoticeStaggeringsExtensions
{
    public static NoticeStaggering ToDto(this NoticeStaggeringDbModel model)
    {
        return new NoticeStaggering
        {
            AttachmentId = model.AttachmentId,
            CreatedAt = model.CreatedAt,
            DeletionOn = model.DeletionOn,
            FinalModificationDateAndTime = model.FinalModificationDateAndTime,
            FinalModifierId = model.FinalModifierId,
            FirstRegistrantId = model.FirstRegistrantId,
            FirstRegistrationDateAndTime = model.FirstRegistrationDateAndTime,
            Id = model.Id,
            NoticeNo = model.NoticeNo,
            NumberOfStaggeredNotices = model.NumberOfStaggeredNotices,
            OfficeCode = model.OfficeCode,
            RegisteringPersonId = model.RegisteringPersonId,
            ServiceCode = model.ServiceCode,
            StaggeredNoticesGroupingDate = model.StaggeredNoticesGroupingDate,
            StaggeredNoticesGroupingPersonId = model.StaggeredNoticesGroupingPersonId,
            StaggeredNoticesGroupingReasonContent = model.StaggeredNoticesGroupingReasonContent,
            StaggeringDate = model.StaggeringDate,
            StaggeringReasonContent = model.StaggeringReasonContent,
            UpdatedAt = model.UpdatedAt
        };
    }

    public static NoticeStaggeringDbModel ToModel(
        this NoticeStaggeringUpdateInput updateDto,
        NoticeStaggeringWhereUniqueInput uniqueId
    )
    {
        var noticeStaggering = new NoticeStaggeringDbModel
        {
            Id = uniqueId.Id,
            AttachmentId = updateDto.AttachmentId,
            DeletionOn = updateDto.DeletionOn,
            FinalModificationDateAndTime = updateDto.FinalModificationDateAndTime,
            FinalModifierId = updateDto.FinalModifierId,
            FirstRegistrantId = updateDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = updateDto.FirstRegistrationDateAndTime,
            NoticeNo = updateDto.NoticeNo,
            NumberOfStaggeredNotices = updateDto.NumberOfStaggeredNotices,
            OfficeCode = updateDto.OfficeCode,
            RegisteringPersonId = updateDto.RegisteringPersonId,
            ServiceCode = updateDto.ServiceCode,
            StaggeredNoticesGroupingDate = updateDto.StaggeredNoticesGroupingDate,
            StaggeredNoticesGroupingPersonId = updateDto.StaggeredNoticesGroupingPersonId,
            StaggeredNoticesGroupingReasonContent = updateDto.StaggeredNoticesGroupingReasonContent,
            StaggeringDate = updateDto.StaggeringDate,
            StaggeringReasonContent = updateDto.StaggeringReasonContent
        };

        if (updateDto.CreatedAt != null) noticeStaggering.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) noticeStaggering.UpdatedAt = updateDto.UpdatedAt.Value;

        return noticeStaggering;
    }
}

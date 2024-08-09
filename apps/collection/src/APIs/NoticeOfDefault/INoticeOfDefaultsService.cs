using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface INoticeOfDefaultsService
{
    /// <summary>
    /// Create one NOTICE OF DEFAULT
    /// </summary>
    public Task<NoticeOfDefault> CreateNoticeOfDefault(NoticeOfDefaultCreateInput noticeofdefault);

    /// <summary>
    /// Delete one NOTICE OF DEFAULT
    /// </summary>
    public Task DeleteNoticeOfDefault(NoticeOfDefaultWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many NOTICE OF DEFAULTS
    /// </summary>
    public Task<List<NoticeOfDefault>> NoticeOfDefaults(NoticeOfDefaultFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about NOTICE OF DEFAULT records
    /// </summary>
    public Task<MetadataDto> NoticeOfDefaultsMeta(NoticeOfDefaultFindManyArgs findManyArgs);

    /// <summary>
    /// Get one NOTICE OF DEFAULT
    /// </summary>
    public Task<NoticeOfDefault> NoticeOfDefault(NoticeOfDefaultWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one NOTICE OF DEFAULT
    /// </summary>
    public Task UpdateNoticeOfDefault(
        NoticeOfDefaultWhereUniqueInput uniqueId,
        NoticeOfDefaultUpdateInput updateDto
    );
}

using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface INoticesService
{
    /// <summary>
    ///     Create one NOTICE
    /// </summary>
    public Task<Notice> CreateNotice(NoticeCreateInput notice);

    /// <summary>
    ///     Delete one NOTICE
    /// </summary>
    public Task DeleteNotice(NoticeWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many NOTICES
    /// </summary>
    public Task<List<Notice>> Notices(NoticeFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about NOTICE records
    /// </summary>
    public Task<MetadataDto> NoticesMeta(NoticeFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one NOTICE
    /// </summary>
    public Task<Notice> Notice(NoticeWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one NOTICE
    /// </summary>
    public Task UpdateNotice(NoticeWhereUniqueInput uniqueId, NoticeUpdateInput updateDto);
}

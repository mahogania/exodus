using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface INoticeStaggeringsService
{
    /// <summary>
    ///     Create one NOTICE STAGGERING
    /// </summary>
    public Task<NoticeStaggering> CreateNoticeStaggering(
        NoticeStaggeringCreateInput noticestaggering
    );

    /// <summary>
    ///     Delete one NOTICE STAGGERING
    /// </summary>
    public Task DeleteNoticeStaggering(NoticeStaggeringWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many NOTICE STAGGERINGS
    /// </summary>
    public Task<List<NoticeStaggering>> NoticeStaggerings(
        NoticeStaggeringFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about NOTICE STAGGERING records
    /// </summary>
    public Task<MetadataDto> NoticeStaggeringsMeta(NoticeStaggeringFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one NOTICE STAGGERING
    /// </summary>
    public Task<NoticeStaggering> NoticeStaggering(NoticeStaggeringWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one NOTICE STAGGERING
    /// </summary>
    public Task UpdateNoticeStaggering(
        NoticeStaggeringWhereUniqueInput uniqueId,
        NoticeStaggeringUpdateInput updateDto
    );
}

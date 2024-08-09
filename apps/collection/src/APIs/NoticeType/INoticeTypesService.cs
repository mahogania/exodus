using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface INoticeTypesService
{
    /// <summary>
    /// Create one NOTICE TYPE
    /// </summary>
    public Task<NoticeType> CreateNoticeType(NoticeTypeCreateInput noticetype);

    /// <summary>
    /// Delete one NOTICE TYPE
    /// </summary>
    public Task DeleteNoticeType(NoticeTypeWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many NOTICE TYPES
    /// </summary>
    public Task<List<NoticeType>> NoticeTypes(NoticeTypeFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about NOTICE TYPE records
    /// </summary>
    public Task<MetadataDto> NoticeTypesMeta(NoticeTypeFindManyArgs findManyArgs);

    /// <summary>
    /// Get one NOTICE TYPE
    /// </summary>
    public Task<NoticeType> NoticeType(NoticeTypeWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one NOTICE TYPE
    /// </summary>
    public Task UpdateNoticeType(
        NoticeTypeWhereUniqueInput uniqueId,
        NoticeTypeUpdateInput updateDto
    );
}

using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IFormalNoticesService
{
    /// <summary>
    ///     Create one FORMAL NOTICE
    /// </summary>
    public Task<FormalNotice> CreateFormalNotice(FormalNoticeCreateInput formalnotice);

    /// <summary>
    ///     Delete one FORMAL NOTICE
    /// </summary>
    public Task DeleteFormalNotice(FormalNoticeWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many FORMAL NOTICES
    /// </summary>
    public Task<List<FormalNotice>> FormalNotices(FormalNoticeFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about FORMAL NOTICE records
    /// </summary>
    public Task<MetadataDto> FormalNoticesMeta(FormalNoticeFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one FORMAL NOTICE
    /// </summary>
    public Task<FormalNotice> FormalNotice(FormalNoticeWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one FORMAL NOTICE
    /// </summary>
    public Task UpdateFormalNotice(
        FormalNoticeWhereUniqueInput uniqueId,
        FormalNoticeUpdateInput updateDto
    );
}

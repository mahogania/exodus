using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface INoticeCancellationsService
{
    /// <summary>
    /// Create one NOTICE CANCELLATION
    /// </summary>
    public Task<NoticeCancellation> CreateNoticeCancellation(
        NoticeCancellationCreateInput noticecancellation
    );

    /// <summary>
    /// Delete one NOTICE CANCELLATION
    /// </summary>
    public Task DeleteNoticeCancellation(NoticeCancellationWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many NOTICE CANCELLATIONS
    /// </summary>
    public Task<List<NoticeCancellation>> NoticeCancellations(
        NoticeCancellationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about NOTICE CANCELLATION records
    /// </summary>
    public Task<MetadataDto> NoticeCancellationsMeta(NoticeCancellationFindManyArgs findManyArgs);

    /// <summary>
    /// Get one NOTICE CANCELLATION
    /// </summary>
    public Task<NoticeCancellation> NoticeCancellation(NoticeCancellationWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one NOTICE CANCELLATION
    /// </summary>
    public Task UpdateNoticeCancellation(
        NoticeCancellationWhereUniqueInput uniqueId,
        NoticeCancellationUpdateInput updateDto
    );
}

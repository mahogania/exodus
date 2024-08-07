using Statement.APIs.Common;
using Statement.APIs.Dtos;

namespace Statement.APIs;

public interface ICancellationsService
{
    /// <summary>
    /// Create one Cancellation
    /// </summary>
    public Task<Cancellation> CreateCancellation(CancellationCreateInput cancellation);

    /// <summary>
    /// Delete one Cancellation
    /// </summary>
    public Task DeleteCancellation(CancellationWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Cancellations
    /// </summary>
    public Task<List<Cancellation>> Cancellations(CancellationFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Cancellation records
    /// </summary>
    public Task<MetadataDto> CancellationsMeta(CancellationFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Cancellation
    /// </summary>
    public Task<Cancellation> Cancellation(CancellationWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Cancellation
    /// </summary>
    public Task UpdateCancellation(
        CancellationWhereUniqueInput uniqueId,
        CancellationUpdateInput updateDto
    );
}

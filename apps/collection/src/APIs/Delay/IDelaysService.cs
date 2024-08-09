using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IDelaysService
{
    /// <summary>
    /// Create one DELAY
    /// </summary>
    public Task<Delay> CreateDelay(DelayCreateInput delay);

    /// <summary>
    /// Delete one DELAY
    /// </summary>
    public Task DeleteDelay(DelayWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many DELAYS
    /// </summary>
    public Task<List<Delay>> Delays(DelayFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about DELAY records
    /// </summary>
    public Task<MetadataDto> DelaysMeta(DelayFindManyArgs findManyArgs);

    /// <summary>
    /// Get one DELAY
    /// </summary>
    public Task<Delay> Delay(DelayWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one DELAY
    /// </summary>
    public Task UpdateDelay(DelayWhereUniqueInput uniqueId, DelayUpdateInput updateDto);
}

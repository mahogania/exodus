using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface ICausesService
{
    /// <summary>
    /// Create one CAUSE
    /// </summary>
    public Task<Cause> CreateCause(CauseCreateInput cause);

    /// <summary>
    /// Delete one CAUSE
    /// </summary>
    public Task DeleteCause(CauseWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many CAUSES
    /// </summary>
    public Task<List<Cause>> Causes(CauseFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about CAUSE records
    /// </summary>
    public Task<MetadataDto> CausesMeta(CauseFindManyArgs findManyArgs);

    /// <summary>
    /// Get one CAUSE
    /// </summary>
    public Task<Cause> Cause(CauseWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one CAUSE
    /// </summary>
    public Task UpdateCause(CauseWhereUniqueInput uniqueId, CauseUpdateInput updateDto);
}

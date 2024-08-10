using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IFineCausesService
{
    /// <summary>
    ///     Create one FINE CAUSE
    /// </summary>
    public Task<FineCause> CreateFineCause(FineCauseCreateInput finecause);

    /// <summary>
    ///     Delete one FINE CAUSE
    /// </summary>
    public Task DeleteFineCause(FineCauseWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many FINE CAUSES
    /// </summary>
    public Task<List<FineCause>> FineCauses(FineCauseFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about FINE CAUSE records
    /// </summary>
    public Task<MetadataDto> FineCausesMeta(FineCauseFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one FINE CAUSE
    /// </summary>
    public Task<FineCause> FineCause(FineCauseWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one FINE CAUSE
    /// </summary>
    public Task UpdateFineCause(FineCauseWhereUniqueInput uniqueId, FineCauseUpdateInput updateDto);
}

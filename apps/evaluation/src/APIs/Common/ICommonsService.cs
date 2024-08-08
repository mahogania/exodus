using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;

namespace Evaluation.APIs;

public interface ICommonsService
{
    /// <summary>
    /// Create one Common
    /// </summary>
    public Task<Common> CreateCommon(CommonCreateInput common);

    /// <summary>
    /// Delete one Common
    /// </summary>
    public Task DeleteCommon(CommonWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Commons
    /// </summary>
    public Task<List<Common>> Commons(CommonFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Common records
    /// </summary>
    public Task<MetadataDto> CommonsMeta(CommonFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Common
    /// </summary>
    public Task<Common> Common(CommonWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Common
    /// </summary>
    public Task UpdateCommon(CommonWhereUniqueInput uniqueId, CommonUpdateInput updateDto);
}

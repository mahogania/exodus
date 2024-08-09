using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;

namespace Evaluation.APIs;

public interface IDetailsService
{
    /// <summary>
    /// Create one Detail
    /// </summary>
    public Task<Detail> CreateDetail(DetailCreateInput detail);

    /// <summary>
    /// Delete one Detail
    /// </summary>
    public Task DeleteDetail(DetailWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Details
    /// </summary>
    public Task<List<Detail>> Details(DetailFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Detail records
    /// </summary>
    public Task<MetadataDto> DetailsMeta(DetailFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Detail
    /// </summary>
    public Task<Detail> Detail(DetailWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Detail
    /// </summary>
    public Task UpdateDetail(DetailWhereUniqueInput uniqueId, DetailUpdateInput updateDto);
}

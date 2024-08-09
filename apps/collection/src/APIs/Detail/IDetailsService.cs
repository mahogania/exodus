using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IDetailsService
{
    /// <summary>
    /// Create one DETAIL
    /// </summary>
    public Task<Detail> CreateDetail(DetailCreateInput detail);

    /// <summary>
    /// Delete one DETAIL
    /// </summary>
    public Task DeleteDetail(DetailWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many DETAILS
    /// </summary>
    public Task<List<Detail>> Details(DetailFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about DETAIL records
    /// </summary>
    public Task<MetadataDto> DetailsMeta(DetailFindManyArgs findManyArgs);

    /// <summary>
    /// Get one DETAIL
    /// </summary>
    public Task<Detail> Detail(DetailWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one DETAIL
    /// </summary>
    public Task UpdateDetail(DetailWhereUniqueInput uniqueId, DetailUpdateInput updateDto);
}

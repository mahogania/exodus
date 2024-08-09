using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IOthersItemsService
{
    /// <summary>
    /// Create one OTHERS
    /// </summary>
    public Task<Others> CreateOthers(OthersCreateInput others);

    /// <summary>
    /// Delete one OTHERS
    /// </summary>
    public Task DeleteOthers(OthersWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many OTHERSItems
    /// </summary>
    public Task<List<Others>> OthersItems(OthersFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about OTHERS records
    /// </summary>
    public Task<MetadataDto> OthersItemsMeta(OthersFindManyArgs findManyArgs);

    /// <summary>
    /// Get one OTHERS
    /// </summary>
    public Task<Others> Others(OthersWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one OTHERS
    /// </summary>
    public Task UpdateOthers(OthersWhereUniqueInput uniqueId, OthersUpdateInput updateDto);
}

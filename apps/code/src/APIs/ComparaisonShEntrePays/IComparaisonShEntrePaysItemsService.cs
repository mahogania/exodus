using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IComparaisonShEntrePaysItemsService
{
    /// <summary>
    /// Create one ComparaisonShEntrePays
    /// </summary>
    public Task<ComparaisonShEntrePays> CreateComparaisonShEntrePays(
        ComparaisonShEntrePaysCreateInput comparaisonshentrepays
    );

    /// <summary>
    /// Delete one ComparaisonShEntrePays
    /// </summary>
    public Task DeleteComparaisonShEntrePays(ComparaisonShEntrePaysWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many ComparaisonShEntrePaysItems
    /// </summary>
    public Task<List<ComparaisonShEntrePays>> ComparaisonShEntrePaysItems(
        ComparaisonShEntrePaysFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ComparaisonShEntrePays records
    /// </summary>
    public Task<MetadataDto> ComparaisonShEntrePaysItemsMeta(
        ComparaisonShEntrePaysFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ComparaisonShEntrePays
    /// </summary>
    public Task<ComparaisonShEntrePays> ComparaisonShEntrePays(
        ComparaisonShEntrePaysWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ComparaisonShEntrePays
    /// </summary>
    public Task UpdateComparaisonShEntrePays(
        ComparaisonShEntrePaysWhereUniqueInput uniqueId,
        ComparaisonShEntrePaysUpdateInput updateDto
    );
}

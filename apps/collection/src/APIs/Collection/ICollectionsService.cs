using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface ICollectionsService
{
    /// <summary>
    /// Create one COLLECTION
    /// </summary>
    public Task<Collection> CreateCollection(CollectionCreateInput collection);

    /// <summary>
    /// Delete one COLLECTION
    /// </summary>
    public Task DeleteCollection(CollectionWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many COLLECTIONS
    /// </summary>
    public Task<List<Collection>> Collections(CollectionFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about COLLECTION records
    /// </summary>
    public Task<MetadataDto> CollectionsMeta(CollectionFindManyArgs findManyArgs);

    /// <summary>
    /// Get one COLLECTION
    /// </summary>
    public Task<Collection> Collection(CollectionWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one COLLECTION
    /// </summary>
    public Task UpdateCollection(
        CollectionWhereUniqueInput uniqueId,
        CollectionUpdateInput updateDto
    );
}

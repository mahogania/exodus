using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IShAnalyseCollectionsService
{
    /// <summary>
    /// Create one ShAnalyseCollection
    /// </summary>
    public Task<ShAnalyseCollection> CreateShAnalyseCollection(
        ShAnalyseCollectionCreateInput shanalysecollection
    );

    /// <summary>
    /// Delete one ShAnalyseCollection
    /// </summary>
    public Task DeleteShAnalyseCollection(ShAnalyseCollectionWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many ShAnalyseCollections
    /// </summary>
    public Task<List<ShAnalyseCollection>> ShAnalyseCollections(
        ShAnalyseCollectionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ShAnalyseCollection records
    /// </summary>
    public Task<MetadataDto> ShAnalyseCollectionsMeta(ShAnalyseCollectionFindManyArgs findManyArgs);

    /// <summary>
    /// Get one ShAnalyseCollection
    /// </summary>
    public Task<ShAnalyseCollection> ShAnalyseCollection(
        ShAnalyseCollectionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ShAnalyseCollection
    /// </summary>
    public Task UpdateShAnalyseCollection(
        ShAnalyseCollectionWhereUniqueInput uniqueId,
        ShAnalyseCollectionUpdateInput updateDto
    );
}

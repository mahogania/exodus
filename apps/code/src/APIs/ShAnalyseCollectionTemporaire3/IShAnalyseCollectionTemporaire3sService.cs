using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IShAnalyseCollectionTemporaire3sService
{
    /// <summary>
    /// Create one ShAnalyseCollectionTemporaire3
    /// </summary>
    public Task<ShAnalyseCollectionTemporaire3> CreateShAnalyseCollectionTemporaire3(
        ShAnalyseCollectionTemporaire3CreateInput shanalysecollectiontemporaire3
    );

    /// <summary>
    /// Delete one ShAnalyseCollectionTemporaire3
    /// </summary>
    public Task DeleteShAnalyseCollectionTemporaire3(
        ShAnalyseCollectionTemporaire3WhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many ShAnalyseCollectionTemporaire3s
    /// </summary>
    public Task<List<ShAnalyseCollectionTemporaire3>> ShAnalyseCollectionTemporaire3s(
        ShAnalyseCollectionTemporaire3FindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ShAnalyseCollectionTemporaire3 records
    /// </summary>
    public Task<MetadataDto> ShAnalyseCollectionTemporaire3sMeta(
        ShAnalyseCollectionTemporaire3FindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ShAnalyseCollectionTemporaire3
    /// </summary>
    public Task<ShAnalyseCollectionTemporaire3> ShAnalyseCollectionTemporaire3(
        ShAnalyseCollectionTemporaire3WhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ShAnalyseCollectionTemporaire3
    /// </summary>
    public Task UpdateShAnalyseCollectionTemporaire3(
        ShAnalyseCollectionTemporaire3WhereUniqueInput uniqueId,
        ShAnalyseCollectionTemporaire3UpdateInput updateDto
    );
}

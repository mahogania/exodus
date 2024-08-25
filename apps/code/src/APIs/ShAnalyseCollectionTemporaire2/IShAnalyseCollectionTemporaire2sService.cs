using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IShAnalyseCollectionTemporaire2sService
{
    /// <summary>
    /// Create one ShAnalyseCollectionTemporaire2
    /// </summary>
    public Task<ShAnalyseCollectionTemporaire2> CreateShAnalyseCollectionTemporaire2(
        ShAnalyseCollectionTemporaire2CreateInput shanalysecollectiontemporaire2
    );

    /// <summary>
    /// Delete one ShAnalyseCollectionTemporaire2
    /// </summary>
    public Task DeleteShAnalyseCollectionTemporaire2(
        ShAnalyseCollectionTemporaire2WhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many ShAnalyseCollectionTemporaire2s
    /// </summary>
    public Task<List<ShAnalyseCollectionTemporaire2>> ShAnalyseCollectionTemporaire2s(
        ShAnalyseCollectionTemporaire2FindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ShAnalyseCollectionTemporaire2 records
    /// </summary>
    public Task<MetadataDto> ShAnalyseCollectionTemporaire2sMeta(
        ShAnalyseCollectionTemporaire2FindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ShAnalyseCollectionTemporaire2
    /// </summary>
    public Task<ShAnalyseCollectionTemporaire2> ShAnalyseCollectionTemporaire2(
        ShAnalyseCollectionTemporaire2WhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ShAnalyseCollectionTemporaire2
    /// </summary>
    public Task UpdateShAnalyseCollectionTemporaire2(
        ShAnalyseCollectionTemporaire2WhereUniqueInput uniqueId,
        ShAnalyseCollectionTemporaire2UpdateInput updateDto
    );
}

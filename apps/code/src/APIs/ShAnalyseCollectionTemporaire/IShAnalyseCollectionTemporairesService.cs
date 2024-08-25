using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IShAnalyseCollectionTemporairesService
{
    /// <summary>
    /// Create one ShAnalyseCollectionTemporaire
    /// </summary>
    public Task<ShAnalyseCollectionTemporaire> CreateShAnalyseCollectionTemporaire(
        ShAnalyseCollectionTemporaireCreateInput shanalysecollectiontemporaire
    );

    /// <summary>
    /// Delete one ShAnalyseCollectionTemporaire
    /// </summary>
    public Task DeleteShAnalyseCollectionTemporaire(
        ShAnalyseCollectionTemporaireWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many ShAnalyseCollectionTemporaires
    /// </summary>
    public Task<List<ShAnalyseCollectionTemporaire>> ShAnalyseCollectionTemporaires(
        ShAnalyseCollectionTemporaireFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ShAnalyseCollectionTemporaire records
    /// </summary>
    public Task<MetadataDto> ShAnalyseCollectionTemporairesMeta(
        ShAnalyseCollectionTemporaireFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ShAnalyseCollectionTemporaire
    /// </summary>
    public Task<ShAnalyseCollectionTemporaire> ShAnalyseCollectionTemporaire(
        ShAnalyseCollectionTemporaireWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ShAnalyseCollectionTemporaire
    /// </summary>
    public Task UpdateShAnalyseCollectionTemporaire(
        ShAnalyseCollectionTemporaireWhereUniqueInput uniqueId,
        ShAnalyseCollectionTemporaireUpdateInput updateDto
    );
}

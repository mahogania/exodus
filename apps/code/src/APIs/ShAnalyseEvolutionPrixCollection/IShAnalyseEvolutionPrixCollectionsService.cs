using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IShAnalyseEvolutionPrixCollectionsService
{
    /// <summary>
    /// Create one ShAnalyseEvolutionPrixCollection
    /// </summary>
    public Task<ShAnalyseEvolutionPrixCollection> CreateShAnalyseEvolutionPrixCollection(
        ShAnalyseEvolutionPrixCollectionCreateInput shanalyseevolutionprixcollection
    );

    /// <summary>
    /// Delete one ShAnalyseEvolutionPrixCollection
    /// </summary>
    public Task DeleteShAnalyseEvolutionPrixCollection(
        ShAnalyseEvolutionPrixCollectionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many ShAnalyseEvolutionPrixCollections
    /// </summary>
    public Task<List<ShAnalyseEvolutionPrixCollection>> ShAnalyseEvolutionPrixCollections(
        ShAnalyseEvolutionPrixCollectionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ShAnalyseEvolutionPrixCollection records
    /// </summary>
    public Task<MetadataDto> ShAnalyseEvolutionPrixCollectionsMeta(
        ShAnalyseEvolutionPrixCollectionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ShAnalyseEvolutionPrixCollection
    /// </summary>
    public Task<ShAnalyseEvolutionPrixCollection> ShAnalyseEvolutionPrixCollection(
        ShAnalyseEvolutionPrixCollectionWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ShAnalyseEvolutionPrixCollection
    /// </summary>
    public Task UpdateShAnalyseEvolutionPrixCollection(
        ShAnalyseEvolutionPrixCollectionWhereUniqueInput uniqueId,
        ShAnalyseEvolutionPrixCollectionUpdateInput updateDto
    );
}

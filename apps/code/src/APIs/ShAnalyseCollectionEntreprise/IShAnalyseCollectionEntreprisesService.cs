using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IShAnalyseCollectionEntreprisesService
{
    /// <summary>
    /// Create one ShAnalyseCollectionEntreprise
    /// </summary>
    public Task<ShAnalyseCollectionEntreprise> CreateShAnalyseCollectionEntreprise(
        ShAnalyseCollectionEntrepriseCreateInput shanalysecollectionentreprise
    );

    /// <summary>
    /// Delete one ShAnalyseCollectionEntreprise
    /// </summary>
    public Task DeleteShAnalyseCollectionEntreprise(
        ShAnalyseCollectionEntrepriseWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many ShAnalyseCollectionEntreprises
    /// </summary>
    public Task<List<ShAnalyseCollectionEntreprise>> ShAnalyseCollectionEntreprises(
        ShAnalyseCollectionEntrepriseFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ShAnalyseCollectionEntreprise records
    /// </summary>
    public Task<MetadataDto> ShAnalyseCollectionEntreprisesMeta(
        ShAnalyseCollectionEntrepriseFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ShAnalyseCollectionEntreprise
    /// </summary>
    public Task<ShAnalyseCollectionEntreprise> ShAnalyseCollectionEntreprise(
        ShAnalyseCollectionEntrepriseWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ShAnalyseCollectionEntreprise
    /// </summary>
    public Task UpdateShAnalyseCollectionEntreprise(
        ShAnalyseCollectionEntrepriseWhereUniqueInput uniqueId,
        ShAnalyseCollectionEntrepriseUpdateInput updateDto
    );
}

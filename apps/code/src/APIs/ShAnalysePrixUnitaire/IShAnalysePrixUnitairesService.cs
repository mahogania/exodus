using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IShAnalysePrixUnitairesService
{
    /// <summary>
    /// Create one ShAnalysePrixUnitaire
    /// </summary>
    public Task<ShAnalysePrixUnitaire> CreateShAnalysePrixUnitaire(
        ShAnalysePrixUnitaireCreateInput shanalyseprixunitaire
    );

    /// <summary>
    /// Delete one ShAnalysePrixUnitaire
    /// </summary>
    public Task DeleteShAnalysePrixUnitaire(ShAnalysePrixUnitaireWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many ShAnalysePrixUnitaires
    /// </summary>
    public Task<List<ShAnalysePrixUnitaire>> ShAnalysePrixUnitaires(
        ShAnalysePrixUnitaireFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about ShAnalysePrixUnitaire records
    /// </summary>
    public Task<MetadataDto> ShAnalysePrixUnitairesMeta(
        ShAnalysePrixUnitaireFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one ShAnalysePrixUnitaire
    /// </summary>
    public Task<ShAnalysePrixUnitaire> ShAnalysePrixUnitaire(
        ShAnalysePrixUnitaireWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one ShAnalysePrixUnitaire
    /// </summary>
    public Task UpdateShAnalysePrixUnitaire(
        ShAnalysePrixUnitaireWhereUniqueInput uniqueId,
        ShAnalysePrixUnitaireUpdateInput updateDto
    );
}

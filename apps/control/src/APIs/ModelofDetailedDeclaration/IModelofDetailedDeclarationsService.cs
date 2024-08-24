using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IModelofDetailedDeclarationsService
{
    /// <summary>
    /// Create one Model of Detailed Declaration
    /// </summary>
    public Task<ModelofDetailedDeclaration> CreateModelofDetailedDeclaration(
        ModelofDetailedDeclarationCreateInput modelofdetaileddeclaration
    );

    /// <summary>
    /// Delete one Model of Detailed Declaration
    /// </summary>
    public Task DeleteModelofDetailedDeclaration(
        ModelofDetailedDeclarationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public Task<List<ModelofDetailedDeclaration>> ModelofDetailedDeclarations(
        ModelofDetailedDeclarationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Model of Detailed Declaration records
    /// </summary>
    public Task<MetadataDto> ModelofDetailedDeclarationsMeta(
        ModelofDetailedDeclarationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Model of Detailed Declaration
    /// </summary>
    public Task<ModelofDetailedDeclaration> ModelofDetailedDeclaration(
        ModelofDetailedDeclarationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Model of Detailed Declaration
    /// </summary>
    public Task UpdateModelofDetailedDeclaration(
        ModelofDetailedDeclarationWhereUniqueInput uniqueId,
        ModelofDetailedDeclarationUpdateInput updateDto
    );

    /// <summary>
    /// Get a Article record for Model of Detailed Declaration
    /// </summary>
    public Task<Article> GetArticle(ModelofDetailedDeclarationWhereUniqueInput uniqueId);
}

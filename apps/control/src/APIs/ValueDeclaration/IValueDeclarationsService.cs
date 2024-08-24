using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IValueDeclarationsService
{
    /// <summary>
    /// Create one Value Declaration
    /// </summary>
    public Task<ValueDeclaration> CreateValueDeclaration(
        ValueDeclarationCreateInput valuedeclaration
    );

    /// <summary>
    /// Delete one Value Declaration
    /// </summary>
    public Task DeleteValueDeclaration(ValueDeclarationWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public Task<List<ValueDeclaration>> ValueDeclarations(
        ValueDeclarationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Value Declaration records
    /// </summary>
    public Task<MetadataDto> ValueDeclarationsMeta(ValueDeclarationFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Value Declaration
    /// </summary>
    public Task<ValueDeclaration> ValueDeclaration(ValueDeclarationWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Value Declaration
    /// </summary>
    public Task UpdateValueDeclaration(
        ValueDeclarationWhereUniqueInput uniqueId,
        ValueDeclarationUpdateInput updateDto
    );

    /// <summary>
    /// Get a COMMON DETAILED DECLARATIONS record for DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<CommonDetailedDeclaration> GetCommonDetailedDeclarations(
        ValueDeclarationWhereUniqueInput uniqueId
    );
}

using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonDetailedDeclarationsService
{
    /// <summary>
    /// Create one COMMON DETAILED DECLARATION
    /// </summary>
    public Task<CommonDetailedDeclaration> CreateCommonDetailedDeclaration(
        CommonDetailedDeclarationCreateInput commondetaileddeclaration
    );

    /// <summary>
    /// Delete one COMMON DETAILED DECLARATION
    /// </summary>
    public Task DeleteCommonDetailedDeclaration(CommonDetailedDeclarationWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many COMMON DETAILED DECLARATIONS
    /// </summary>
    public Task<List<CommonDetailedDeclaration>> CommonDetailedDeclarations(
        CommonDetailedDeclarationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about COMMON DETAILED DECLARATION records
    /// </summary>
    public Task<MetadataDto> CommonDetailedDeclarationsMeta(
        CommonDetailedDeclarationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one COMMON DETAILED DECLARATION
    /// </summary>
    public Task<CommonDetailedDeclaration> CommonDetailedDeclaration(
        CommonDetailedDeclarationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one COMMON DETAILED DECLARATION
    /// </summary>
    public Task UpdateCommonDetailedDeclaration(
        CommonDetailedDeclarationWhereUniqueInput uniqueId,
        CommonDetailedDeclarationUpdateInput updateDto
    );
}

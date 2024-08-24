using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IChangeInTheDetailedDeclarationsService
{
    /// <summary>
    /// Create one Change in the Detailed Declaration
    /// </summary>
    public Task<ChangeInTheDetailedDeclaration> CreateChangeInTheDetailedDeclaration(
        ChangeInTheDetailedDeclarationCreateInput changeinthedetaileddeclaration
    );

    /// <summary>
    /// Delete one Change in the Detailed Declaration
    /// </summary>
    public Task DeleteChangeInTheDetailedDeclaration(
        ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Change in the Detailed Declarations
    /// </summary>
    public Task<List<ChangeInTheDetailedDeclaration>> ChangeInTheDetailedDeclarations(
        ChangeInTheDetailedDeclarationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Change in the Detailed Declaration records
    /// </summary>
    public Task<MetadataDto> ChangeInTheDetailedDeclarationsMeta(
        ChangeInTheDetailedDeclarationFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Change in the Detailed Declaration
    /// </summary>
    public Task<ChangeInTheDetailedDeclaration> ChangeInTheDetailedDeclaration(
        ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Change in the Detailed Declaration
    /// </summary>
    public Task UpdateChangeInTheDetailedDeclaration(
        ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId,
        ChangeInTheDetailedDeclarationUpdateInput updateDto
    );

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION record for Change in the Detailed Declaration
    /// </summary>
    public Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(
        ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId
    );
}

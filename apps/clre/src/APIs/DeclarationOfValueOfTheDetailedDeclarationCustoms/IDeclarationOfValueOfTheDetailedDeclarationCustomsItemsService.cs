using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IDeclarationOfValueOfTheDetailedDeclarationCustomsItemsService
{
    /// <summary>
    /// Create one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<DeclarationOfValueOfTheDetailedDeclarationCustoms> CreateDeclarationOfValueOfTheDetailedDeclarationCustoms(
        DeclarationOfValueOfTheDetailedDeclarationCustomsCreateInput declarationofvalueofthedetaileddeclarationcustoms
    );

    /// <summary>
    /// Delete one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task DeleteDeclarationOfValueOfTheDetailedDeclarationCustoms(
        DeclarationOfValueOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public Task<
        List<DeclarationOfValueOfTheDetailedDeclarationCustoms>
    > DeclarationOfValueOfTheDetailedDeclarationCustomsItems(
        DeclarationOfValueOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public Task<MetadataDto> DeclarationOfValueOfTheDetailedDeclarationCustomsItemsMeta(
        DeclarationOfValueOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<DeclarationOfValueOfTheDetailedDeclarationCustoms> DeclarationOfValueOfTheDetailedDeclarationCustoms(
        DeclarationOfValueOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task UpdateDeclarationOfValueOfTheDetailedDeclarationCustoms(
        DeclarationOfValueOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        DeclarationOfValueOfTheDetailedDeclarationCustomsUpdateInput updateDto
    );
}

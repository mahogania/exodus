using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IModelSpecificationOfTheDetailedDeclarationCustomsItemsService
{
    /// <summary>
    /// Create one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<ModelSpecificationOfTheDetailedDeclarationCustoms> CreateModelSpecificationOfTheDetailedDeclarationCustoms(
        ModelSpecificationOfTheDetailedDeclarationCustomsCreateInput modelspecificationofthedetaileddeclarationcustoms
    );

    /// <summary>
    /// Delete one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task DeleteModelSpecificationOfTheDetailedDeclarationCustoms(
        ModelSpecificationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public Task<
        List<ModelSpecificationOfTheDetailedDeclarationCustoms>
    > ModelSpecificationOfTheDetailedDeclarationCustomsItems(
        ModelSpecificationOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public Task<MetadataDto> ModelSpecificationOfTheDetailedDeclarationCustomsItemsMeta(
        ModelSpecificationOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<ModelSpecificationOfTheDetailedDeclarationCustoms> ModelSpecificationOfTheDetailedDeclarationCustoms(
        ModelSpecificationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task UpdateModelSpecificationOfTheDetailedDeclarationCustoms(
        ModelSpecificationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        ModelSpecificationOfTheDetailedDeclarationCustomsUpdateInput updateDto
    );
}

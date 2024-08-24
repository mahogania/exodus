using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IContainerOfTheDetailedDeclarationCustomsItemsService
{
    /// <summary>
    /// Create one Container Of The Detailed Declaration
    /// </summary>
    public Task<ContainerOfTheDetailedDeclarationCustoms> CreateContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsCreateInput containerofthedetaileddeclarationcustoms
    );

    /// <summary>
    /// Delete one Container Of The Detailed Declaration
    /// </summary>
    public Task DeleteContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public Task<
        List<ContainerOfTheDetailedDeclarationCustoms>
    > ContainerOfTheDetailedDeclarationCustomsItems(
        ContainerOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Container Of The Detailed Declaration records
    /// </summary>
    public Task<MetadataDto> ContainerOfTheDetailedDeclarationCustomsItemsMeta(
        ContainerOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Container Of The Detailed Declaration
    /// </summary>
    public Task<ContainerOfTheDetailedDeclarationCustoms> ContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Container Of The Detailed Declaration
    /// </summary>
    public Task UpdateContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        ContainerOfTheDetailedDeclarationCustomsUpdateInput updateDto
    );

    /// <summary>
    /// Get a COMMON DETAILED DECLARATIONS record for CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<CommonDetailedDeclaration> GetCommonDetailedDeclarations(
        ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );
}

using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IContainerOfTheDetailedDeclarationCustomsItemsService
{
    /// <summary>
    /// Create one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<ContainerOfTheDetailedDeclarationCustoms> CreateContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsCreateInput containerofthedetaileddeclarationcustoms
    );

    /// <summary>
    /// Delete one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
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
    /// Meta data about CONTAINER OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public Task<MetadataDto> ContainerOfTheDetailedDeclarationCustomsItemsMeta(
        ContainerOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<ContainerOfTheDetailedDeclarationCustoms> ContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one CONTAINER OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task UpdateContainerOfTheDetailedDeclarationCustoms(
        ContainerOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        ContainerOfTheDetailedDeclarationCustomsUpdateInput updateDto
    );
}

using Fret.APIs.Common;
using Fret.APIs.Dtos;

namespace Fret.APIs;

public interface IContainersService
{
    /// <summary>
    /// Create one Conteneur
    /// </summary>
    public Task<Container> CreateContainer(ContainerCreateInput container);

    /// <summary>
    /// Delete one Conteneur
    /// </summary>
    public Task DeleteContainer(ContainerWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Containers
    /// </summary>
    public Task<List<Container>> Containers(ContainerFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Conteneur records
    /// </summary>
    public Task<MetadataDto> ContainersMeta(ContainerFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Conteneur
    /// </summary>
    public Task<Container> Container(ContainerWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Conteneur
    /// </summary>
    public Task UpdateContainer(ContainerWhereUniqueInput uniqueId, ContainerUpdateInput updateDto);
}

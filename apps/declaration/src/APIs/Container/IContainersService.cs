using Statement.APIs.Common;
using Statement.APIs.Dtos;

namespace Statement.APIs;

public interface IContainersService
{
    /// <summary>
    /// Create one Container
    /// </summary>
    public Task<Container> CreateContainer(ContainerCreateInput container);

    /// <summary>
    /// Delete one Container
    /// </summary>
    public Task DeleteContainer(ContainerWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Containers
    /// </summary>
    public Task<List<Container>> Containers(ContainerFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Container records
    /// </summary>
    public Task<MetadataDto> ContainersMeta(ContainerFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Container
    /// </summary>
    public Task<Container> Container(ContainerWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Container
    /// </summary>
    public Task UpdateContainer(ContainerWhereUniqueInput uniqueId, ContainerUpdateInput updateDto);
}

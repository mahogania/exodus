using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IClearanceFretContainersService
{
    /// <summary>
    /// Create one Clearance Fret Container
    /// </summary>
    public Task<ClearanceFretContainer> CreateClearanceFretContainer(
        ClearanceFretContainerCreateInput clearancefretcontainer
    );

    /// <summary>
    /// Delete one Clearance Fret Container
    /// </summary>
    public Task DeleteClearanceFretContainer(ClearanceFretContainerWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Clearance Fret Containers
    /// </summary>
    public Task<List<ClearanceFretContainer>> ClearanceFretContainers(
        ClearanceFretContainerFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Clearance Fret Container records
    /// </summary>
    public Task<MetadataDto> ClearanceFretContainersMeta(
        ClearanceFretContainerFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Clearance Fret Container
    /// </summary>
    public Task<ClearanceFretContainer> ClearanceFretContainer(
        ClearanceFretContainerWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Clearance Fret Container
    /// </summary>
    public Task UpdateClearanceFretContainer(
        ClearanceFretContainerWhereUniqueInput uniqueId,
        ClearanceFretContainerUpdateInput updateDto
    );

    /// <summary>
    /// Get a Clearance Fret Interface record for Clearance Fret Container
    /// </summary>
    public Task<ClearanceFretInterface> GetClearanceFretInterface(
        ClearanceFretContainerWhereUniqueInput uniqueId
    );
}

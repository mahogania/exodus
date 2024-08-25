using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IClearanceFretInterfacesService
{
    /// <summary>
    /// Create one Clearance Fret Interface
    /// </summary>
    public Task<ClearanceFretInterface> CreateClearanceFretInterface(
        ClearanceFretInterfaceCreateInput clearancefretinterface
    );

    /// <summary>
    /// Delete one Clearance Fret Interface
    /// </summary>
    public Task DeleteClearanceFretInterface(ClearanceFretInterfaceWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Dedouanement Fret Interfaces
    /// </summary>
    public Task<List<ClearanceFretInterface>> ClearanceFretInterfaces(
        ClearanceFretInterfaceFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Clearance Fret Interface records
    /// </summary>
    public Task<MetadataDto> ClearanceFretInterfacesMeta(
        ClearanceFretInterfaceFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Clearance Fret Interface
    /// </summary>
    public Task<ClearanceFretInterface> ClearanceFretInterface(
        ClearanceFretInterfaceWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Clearance Fret Interface
    /// </summary>
    public Task UpdateClearanceFretInterface(
        ClearanceFretInterfaceWhereUniqueInput uniqueId,
        ClearanceFretInterfaceUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple Clearance Fret Container records to Clearance Fret Interface
    /// </summary>
    public Task ConnectClearanceFretContainer(
        ClearanceFretInterfaceWhereUniqueInput uniqueId,
        ClearanceFretContainerWhereUniqueInput[] clearanceFretContainersId
    );

    /// <summary>
    /// Disconnect multiple Clearance Fret Container records from Clearance Fret Interface
    /// </summary>
    public Task DisconnectClearanceFretContainer(
        ClearanceFretInterfaceWhereUniqueInput uniqueId,
        ClearanceFretContainerWhereUniqueInput[] clearanceFretContainersId
    );

    /// <summary>
    /// Find multiple Clearance Fret Container records for Clearance Fret Interface
    /// </summary>
    public Task<List<ClearanceFretContainer>> FindClearanceFretContainer(
        ClearanceFretInterfaceWhereUniqueInput uniqueId,
        ClearanceFretContainerFindManyArgs ClearanceFretContainerFindManyArgs
    );

    /// <summary>
    /// Update multiple Clearance Fret Container records for Clearance Fret Interface
    /// </summary>
    public Task UpdateClearanceFretContainer(
        ClearanceFretInterfaceWhereUniqueInput uniqueId,
        ClearanceFretContainerWhereUniqueInput[] clearanceFretContainersId
    );
}

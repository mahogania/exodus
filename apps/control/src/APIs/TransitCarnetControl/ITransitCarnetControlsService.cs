using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ITransitCarnetControlsService
{
    /// <summary>
    /// Create one Transit Carnet Control
    /// </summary>
    public Task<TransitCarnetControl> CreateTransitCarnetControl(
        TransitCarnetControlCreateInput transitcarnetcontrol
    );

    /// <summary>
    /// Delete one Transit Carnet Control
    /// </summary>
    public Task DeleteTransitCarnetControl(TransitCarnetControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Transit Carnet Controls
    /// </summary>
    public Task<List<TransitCarnetControl>> TransitCarnetControls(
        TransitCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Transit Carnet Control records
    /// </summary>
    public Task<MetadataDto> TransitCarnetControlsMeta(
        TransitCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Transit Carnet Control
    /// </summary>
    public Task<TransitCarnetControl> TransitCarnetControl(
        TransitCarnetControlWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Transit Carnet Control
    /// </summary>
    public Task UpdateTransitCarnetControl(
        TransitCarnetControlWhereUniqueInput uniqueId,
        TransitCarnetControlUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple Transit Carnet Requests records to Transit Carnet Control
    /// </summary>
    public Task ConnectTransitCarnetRequests(
        TransitCarnetControlWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Transit Carnet Requests records from Transit Carnet Control
    /// </summary>
    public Task DisconnectTransitCarnetRequests(
        TransitCarnetControlWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Transit Carnet Requests records for Transit Carnet Control
    /// </summary>
    public Task<List<TransitCarnetRequest>> FindTransitCarnetRequests(
        TransitCarnetControlWhereUniqueInput uniqueId,
        TransitCarnetRequestFindManyArgs TransitCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Transit Carnet Requests records for Transit Carnet Control
    /// </summary>
    public Task UpdateTransitCarnetRequests(
        TransitCarnetControlWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );
}

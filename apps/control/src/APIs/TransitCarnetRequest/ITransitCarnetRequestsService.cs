using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ITransitCarnetRequestsService
{
    /// <summary>
    /// Create one Transit Carnet Request
    /// </summary>
    public Task<TransitCarnetRequest> CreateTransitCarnetRequest(
        TransitCarnetRequestCreateInput transitcarnetrequest
    );

    /// <summary>
    /// Delete one Transit Carnet Request
    /// </summary>
    public Task DeleteTransitCarnetRequest(TransitCarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Transit Carnet Requests
    /// </summary>
    public Task<List<TransitCarnetRequest>> TransitCarnetRequests(
        TransitCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Transit Carnet Request records
    /// </summary>
    public Task<MetadataDto> TransitCarnetRequestsMeta(
        TransitCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Transit Carnet Request
    /// </summary>
    public Task<TransitCarnetRequest> TransitCarnetRequest(
        TransitCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Transit Carnet Request
    /// </summary>
    public Task UpdateTransitCarnetRequest(
        TransitCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Carnet Request record for Transit Carnet Request
    /// </summary>
    public Task<CarnetRequest> GetCarnetRequest(TransitCarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a Transit Carnet Control record for Transit Carnet Request
    /// </summary>
    public Task<TransitCarnetControl> GetTransitCarnetControl(
        TransitCarnetRequestWhereUniqueInput uniqueId
    );
}

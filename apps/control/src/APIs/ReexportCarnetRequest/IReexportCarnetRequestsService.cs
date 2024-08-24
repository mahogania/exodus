using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IReexportCarnetRequestsService
{
    /// <summary>
    /// Create one Reexport Carnet Request
    /// </summary>
    public Task<ReexportCarnetRequest> CreateReexportCarnetRequest(
        ReexportCarnetRequestCreateInput reexportcarnetrequest
    );

    /// <summary>
    /// Delete one Reexport Carnet Request
    /// </summary>
    public Task DeleteReexportCarnetRequest(ReexportCarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Reexport Carnet Requests
    /// </summary>
    public Task<List<ReexportCarnetRequest>> ReexportCarnetRequests(
        ReexportCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Reexport Carnet Request records
    /// </summary>
    public Task<MetadataDto> ReexportCarnetRequestsMeta(
        ReexportCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Reexport Carnet Request
    /// </summary>
    public Task<ReexportCarnetRequest> ReexportCarnetRequest(
        ReexportCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Reexport Carnet Request
    /// </summary>
    public Task UpdateReexportCarnetRequest(
        ReexportCarnetRequestWhereUniqueInput uniqueId,
        ReexportCarnetRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Carnet Request record for Reexport Carnet Request
    /// </summary>
    public Task<CarnetRequest> GetCarnetRequest(ReexportCarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a Reexport Carnet Control record for Reexport Carnet Request
    /// </summary>
    public Task<ReexportCarnetControl> GetReexportCarnetControl(
        ReexportCarnetRequestWhereUniqueInput uniqueId
    );
}

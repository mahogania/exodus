using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonCarnetRequestsService
{
    /// <summary>
    /// Create one Common Carnet Request
    /// </summary>
    public Task<CommonCarnetRequest> CreateCommonCarnetRequest(
        CommonCarnetRequestCreateInput commoncarnetrequest
    );

    /// <summary>
    /// Delete one Common Carnet Request
    /// </summary>
    public Task DeleteCommonCarnetRequest(CommonCarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Common Carnet Requests
    /// </summary>
    public Task<List<CommonCarnetRequest>> CommonCarnetRequests(
        CommonCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Common Carnet Request records
    /// </summary>
    public Task<MetadataDto> CommonCarnetRequestsMeta(CommonCarnetRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Common Carnet Request
    /// </summary>
    public Task<CommonCarnetRequest> CommonCarnetRequest(
        CommonCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Common Carnet Request
    /// </summary>
    public Task UpdateCommonCarnetRequest(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CommonCarnetRequestUpdateInput updateDto
    );

    /// <summary>
    /// Connect multiple Carnet Requests records to Common Carnet Request
    /// </summary>
    public Task ConnectCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestWhereUniqueInput[] carnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Carnet Requests records from Common Carnet Request
    /// </summary>
    public Task DisconnectCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestWhereUniqueInput[] carnetRequestsId
    );

    /// <summary>
    /// Find multiple Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task<List<CarnetRequest>> FindCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestFindManyArgs CarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task UpdateCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestWhereUniqueInput[] carnetRequestsId
    );
}

using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICarnetRequestsService
{
    /// <summary>
    /// Create one Carnet Request
    /// </summary>
    public Task<CarnetRequest> CreateCarnetRequest(CarnetRequestCreateInput carnetrequest);

    /// <summary>
    /// Delete one Carnet Request
    /// </summary>
    public Task DeleteCarnetRequest(CarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Carnet Requests
    /// </summary>
    public Task<List<CarnetRequest>> CarnetRequests(CarnetRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Carnet Request records
    /// </summary>
    public Task<MetadataDto> CarnetRequestsMeta(CarnetRequestFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Carnet Request
    /// </summary>
    public Task<CarnetRequest> CarnetRequest(CarnetRequestWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Carnet Request
    /// </summary>
    public Task UpdateCarnetRequest(
        CarnetRequestWhereUniqueInput uniqueId,
        CarnetRequestUpdateInput updateDto
    );
}

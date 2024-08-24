using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IExtendedPeriodCarnetRequestsService
{
    /// <summary>
    /// Create one Extended Period Carnet Request
    /// </summary>
    public Task<ExtendedPeriodCarnetRequest> CreateExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetRequestCreateInput extendedperiodcarnetrequest
    );

    /// <summary>
    /// Delete one Extended Period Carnet Request
    /// </summary>
    public Task DeleteExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many Extended Period Carnet Requests
    /// </summary>
    public Task<List<ExtendedPeriodCarnetRequest>> ExtendedPeriodCarnetRequests(
        ExtendedPeriodCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Extended Period Carnet Request records
    /// </summary>
    public Task<MetadataDto> ExtendedPeriodCarnetRequestsMeta(
        ExtendedPeriodCarnetRequestFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Extended Period Carnet Request
    /// </summary>
    public Task<ExtendedPeriodCarnetRequest> ExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Extended Period Carnet Request
    /// </summary>
    public Task UpdateExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestUpdateInput updateDto
    );

    /// <summary>
    /// Get a Carnet Request record for Extended Period Carnet Request
    /// </summary>
    public Task<CarnetRequest> GetCarnetRequest(
        ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Get a Extended Period Carnet Control record for Extended Period Carnet Request
    /// </summary>
    public Task<ExtendedPeriodCarnetControl> GetExtendedPeriodCarnetControl(
        ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    );
}

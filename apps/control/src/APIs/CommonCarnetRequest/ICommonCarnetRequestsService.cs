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
    /// Connect multiple Extended Period Carnet Requests records to Common Carnet Request
    /// </summary>
    public Task ConnectExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Extended Period Carnet Requests records from Common Carnet Request
    /// </summary>
    public Task DisconnectExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Extended Period Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task<List<ExtendedPeriodCarnetRequest>> FindExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestFindManyArgs ExtendedPeriodCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Extended Period Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task UpdateExtendedPeriodCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        ExtendedPeriodCarnetRequestWhereUniqueInput[] extendedPeriodCarnetRequestsId
    );

    /// <summary>
    /// Connect multiple Transit Carnet Requests records to Common Carnet Request
    /// </summary>
    public Task ConnectTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );

    /// <summary>
    /// Disconnect multiple Transit Carnet Requests records from Common Carnet Request
    /// </summary>
    public Task DisconnectTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );

    /// <summary>
    /// Find multiple Transit Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task<List<TransitCarnetRequest>> FindTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestFindManyArgs TransitCarnetRequestFindManyArgs
    );

    /// <summary>
    /// Update multiple Transit Carnet Requests records for Common Carnet Request
    /// </summary>
    public Task UpdateTransitCarnetRequests(
        CommonCarnetRequestWhereUniqueInput uniqueId,
        TransitCarnetRequestWhereUniqueInput[] transitCarnetRequestsId
    );
}

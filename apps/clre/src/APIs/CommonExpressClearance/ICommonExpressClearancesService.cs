using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface ICommonExpressClearancesService
{
    /// <summary>
    /// Create one COMMON EXPRESS CLEARANCE
    /// </summary>
    public Task<CommonExpressClearance> CreateCommonExpressClearance(
        CommonExpressClearanceCreateInput commonexpressclearance
    );

    /// <summary>
    /// Delete one COMMON EXPRESS CLEARANCE
    /// </summary>
    public Task DeleteCommonExpressClearance(CommonExpressClearanceWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many COMMON EXPRESS CLEARANCES
    /// </summary>
    public Task<List<CommonExpressClearance>> CommonExpressClearances(
        CommonExpressClearanceFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about COMMON EXPRESS CLEARANCE records
    /// </summary>
    public Task<MetadataDto> CommonExpressClearancesMeta(
        CommonExpressClearanceFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one COMMON EXPRESS CLEARANCE
    /// </summary>
    public Task<CommonExpressClearance> CommonExpressClearance(
        CommonExpressClearanceWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one COMMON EXPRESS CLEARANCE
    /// </summary>
    public Task UpdateCommonExpressClearance(
        CommonExpressClearanceWhereUniqueInput uniqueId,
        CommonExpressClearanceUpdateInput updateDto
    );
}

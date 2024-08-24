using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonExpressClearancesService
{
    /// <summary>
    /// Create one Common Express Clearance
    /// </summary>
    public Task<CommonExpressClearance> CreateCommonExpressClearance(
        CommonExpressClearanceCreateInput commonexpressclearance
    );

    /// <summary>
    /// Delete one Common Express Clearance
    /// </summary>
    public Task DeleteCommonExpressClearance(CommonExpressClearanceWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many COMMON EXPRESS CLEARANCES
    /// </summary>
    public Task<List<CommonExpressClearance>> CommonExpressClearances(
        CommonExpressClearanceFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Common Express Clearance records
    /// </summary>
    public Task<MetadataDto> CommonExpressClearancesMeta(
        CommonExpressClearanceFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Common Express Clearance
    /// </summary>
    public Task<CommonExpressClearance> CommonExpressClearance(
        CommonExpressClearanceWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Common Express Clearance
    /// </summary>
    public Task UpdateCommonExpressClearance(
        CommonExpressClearanceWhereUniqueInput uniqueId,
        CommonExpressClearanceUpdateInput updateDto
    );
}

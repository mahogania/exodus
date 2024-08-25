using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IRvcIssuancesService
{
    /// <summary>
    /// Create one RVC Issuance
    /// </summary>
    public Task<RvcIssuance> CreateRvcIssuance(RvcIssuanceCreateInput rvcissuance);

    /// <summary>
    /// Delete one RVC Issuance
    /// </summary>
    public Task DeleteRvcIssuance(RvcIssuanceWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many RVC Issuances
    /// </summary>
    public Task<List<RvcIssuance>> RvcIssuances(RvcIssuanceFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about RVC Issuance records
    /// </summary>
    public Task<MetadataDto> RvcIssuancesMeta(RvcIssuanceFindManyArgs findManyArgs);

    /// <summary>
    /// Get one RVC Issuance
    /// </summary>
    public Task<RvcIssuance> RvcIssuance(RvcIssuanceWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one RVC Issuance
    /// </summary>
    public Task UpdateRvcIssuance(
        RvcIssuanceWhereUniqueInput uniqueId,
        RvcIssuanceUpdateInput updateDto
    );
}

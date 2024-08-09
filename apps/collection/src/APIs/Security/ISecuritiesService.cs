using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface ISecuritiesService
{
    /// <summary>
    /// Create one SECURITY
    /// </summary>
    public Task<Security> CreateSecurity(SecurityCreateInput security);

    /// <summary>
    /// Delete one SECURITY
    /// </summary>
    public Task DeleteSecurity(SecurityWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many SECURITIES
    /// </summary>
    public Task<List<Security>> Securities(SecurityFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about SECURITY records
    /// </summary>
    public Task<MetadataDto> SecuritiesMeta(SecurityFindManyArgs findManyArgs);

    /// <summary>
    /// Get one SECURITY
    /// </summary>
    public Task<Security> Security(SecurityWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one SECURITY
    /// </summary>
    public Task UpdateSecurity(SecurityWhereUniqueInput uniqueId, SecurityUpdateInput updateDto);
}

using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IServiceChangesService
{
    /// <summary>
    /// Create one Service Change
    /// </summary>
    public Task<ServiceChange> CreateServiceChange(ServiceChangeCreateInput servicechange);

    /// <summary>
    /// Delete one Service Change
    /// </summary>
    public Task DeleteServiceChange(ServiceChangeWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Service Changes
    /// </summary>
    public Task<List<ServiceChange>> ServiceChanges(ServiceChangeFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Service Change records
    /// </summary>
    public Task<MetadataDto> ServiceChangesMeta(ServiceChangeFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Service Change
    /// </summary>
    public Task<ServiceChange> ServiceChange(ServiceChangeWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Service Change
    /// </summary>
    public Task UpdateServiceChange(
        ServiceChangeWhereUniqueInput uniqueId,
        ServiceChangeUpdateInput updateDto
    );
}

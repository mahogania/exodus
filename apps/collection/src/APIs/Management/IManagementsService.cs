using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IManagementsService
{
    /// <summary>
    /// Create one MANAGEMENT
    /// </summary>
    public Task<Management> CreateManagement(ManagementCreateInput management);

    /// <summary>
    /// Delete one MANAGEMENT
    /// </summary>
    public Task DeleteManagement(ManagementWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many MANAGEMENTS
    /// </summary>
    public Task<List<Management>> Managements(ManagementFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about MANAGEMENT records
    /// </summary>
    public Task<MetadataDto> ManagementsMeta(ManagementFindManyArgs findManyArgs);

    /// <summary>
    /// Get one MANAGEMENT
    /// </summary>
    public Task<Management> Management(ManagementWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one MANAGEMENT
    /// </summary>
    public Task UpdateManagement(
        ManagementWhereUniqueInput uniqueId,
        ManagementUpdateInput updateDto
    );
}

using Criteria.APIs.Common;
using Criteria.APIs.Dtos;

namespace Criteria.APIs;

public interface IInspectorChangesService
{
    /// <summary>
    /// Create one Inspector Change
    /// </summary>
    public Task<InspectorChange> CreateInspectorChange(InspectorChangeCreateInput inspectorchange);

    /// <summary>
    /// Delete one Inspector Change
    /// </summary>
    public Task DeleteInspectorChange(InspectorChangeWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Inspector Changes
    /// </summary>
    public Task<List<InspectorChange>> InspectorChanges(InspectorChangeFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Inspector Change records
    /// </summary>
    public Task<MetadataDto> InspectorChangesMeta(InspectorChangeFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Inspector Change
    /// </summary>
    public Task<InspectorChange> InspectorChange(InspectorChangeWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Inspector Change
    /// </summary>
    public Task UpdateInspectorChange(
        InspectorChangeWhereUniqueInput uniqueId,
        InspectorChangeUpdateInput updateDto
    );
}

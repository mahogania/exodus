using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IStateForPerfectionsService
{
    /// <summary>
    /// Create one State For Perfection
    /// </summary>
    public Task<StateForPerfection> CreateStateForPerfection(
        StateForPerfectionCreateInput stateforperfection
    );

    /// <summary>
    /// Delete one State For Perfection
    /// </summary>
    public Task DeleteStateForPerfection(StateForPerfectionWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many STATE FOR PERFECTIONS
    /// </summary>
    public Task<List<StateForPerfection>> StateForPerfections(
        StateForPerfectionFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about State For Perfection records
    /// </summary>
    public Task<MetadataDto> StateForPerfectionsMeta(StateForPerfectionFindManyArgs findManyArgs);

    /// <summary>
    /// Get one State For Perfection
    /// </summary>
    public Task<StateForPerfection> StateForPerfection(StateForPerfectionWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one State For Perfection
    /// </summary>
    public Task UpdateStateForPerfection(
        StateForPerfectionWhereUniqueInput uniqueId,
        StateForPerfectionUpdateInput updateDto
    );
}

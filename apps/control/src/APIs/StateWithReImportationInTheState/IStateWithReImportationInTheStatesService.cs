using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IStateWithReImportationInTheStatesService
{
    /// <summary>
    /// Create one State With ReImportation In The State
    /// </summary>
    public Task<StateWithReImportationInTheState> CreateStateWithReImportationInTheState(
        StateWithReImportationInTheStateCreateInput statewithreimportationinthestate
    );

    /// <summary>
    /// Delete one State With ReImportation In The State
    /// </summary>
    public Task DeleteStateWithReImportationInTheState(
        StateWithReImportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many STATE WITH RE-IMPORTATION IN THE STATES
    /// </summary>
    public Task<List<StateWithReImportationInTheState>> StateWithReImportationInTheStates(
        StateWithReImportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about State With ReImportation In The State records
    /// </summary>
    public Task<MetadataDto> StateWithReImportationInTheStatesMeta(
        StateWithReImportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one State With ReImportation In The State
    /// </summary>
    public Task<StateWithReImportationInTheState> StateWithReImportationInTheState(
        StateWithReImportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one State With ReImportation In The State
    /// </summary>
    public Task UpdateStateWithReImportationInTheState(
        StateWithReImportationInTheStateWhereUniqueInput uniqueId,
        StateWithReImportationInTheStateUpdateInput updateDto
    );
}

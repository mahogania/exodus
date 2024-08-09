using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IStateWithReImportationInTheStatesService
{
    /// <summary>
    /// Create one STATE WITH RE-IMPORTATION IN THE STATE
    /// </summary>
    public Task<StateWithReImportationInTheState> CreateStateWithReImportationInTheState(
        StateWithReImportationInTheStateCreateInput statewithreimportationinthestate
    );

    /// <summary>
    /// Delete one STATE WITH RE-IMPORTATION IN THE STATE
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
    /// Meta data about STATE WITH RE-IMPORTATION IN THE STATE records
    /// </summary>
    public Task<MetadataDto> StateWithReImportationInTheStatesMeta(
        StateWithReImportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one STATE WITH RE-IMPORTATION IN THE STATE
    /// </summary>
    public Task<StateWithReImportationInTheState> StateWithReImportationInTheState(
        StateWithReImportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one STATE WITH RE-IMPORTATION IN THE STATE
    /// </summary>
    public Task UpdateStateWithReImportationInTheState(
        StateWithReImportationInTheStateWhereUniqueInput uniqueId,
        StateWithReImportationInTheStateUpdateInput updateDto
    );
}

using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IMacSuiteAtWithReexportationInTheStatesService
{
    /// <summary>
    /// Create one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task<MacSuiteAtWithReexportationInTheState> CreateMacSuiteAtWithReexportationInTheState(
        MacSuiteAtWithReexportationInTheStateCreateInput macsuiteatwithreexportationinthestate
    );

    /// <summary>
    /// Delete one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task DeleteMacSuiteAtWithReexportationInTheState(
        MacSuiteAtWithReexportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many MAC SUITE AT WITH REEXPORTATION IN THE STATES
    /// </summary>
    public Task<List<MacSuiteAtWithReexportationInTheState>> MacSuiteAtWithReexportationInTheStates(
        MacSuiteAtWithReexportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about MAC SUITE AT WITH REEXPORTATION IN THE STATE records
    /// </summary>
    public Task<MetadataDto> MacSuiteAtWithReexportationInTheStatesMeta(
        MacSuiteAtWithReexportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task<MacSuiteAtWithReexportationInTheState> MacSuiteAtWithReexportationInTheState(
        MacSuiteAtWithReexportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one MAC SUITE AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task UpdateMacSuiteAtWithReexportationInTheState(
        MacSuiteAtWithReexportationInTheStateWhereUniqueInput uniqueId,
        MacSuiteAtWithReexportationInTheStateUpdateInput updateDto
    );
}

using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IPlaceOfExecutionAtWithReexportationInTheStatesService
{
    /// <summary>
    ///     Create one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task<PlaceOfExecutionAtWithReexportationInTheState> CreatePlaceOfExecutionAtWithReexportationInTheState(
        PlaceOfExecutionAtWithReexportationInTheStateCreateInput placeofexecutionatwithreexportationinthestate
    );

    /// <summary>
    ///     Delete one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task DeletePlaceOfExecutionAtWithReexportationInTheState(
        PlaceOfExecutionAtWithReexportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATES
    /// </summary>
    public Task<
        List<PlaceOfExecutionAtWithReexportationInTheState>
    > PlaceOfExecutionAtWithReexportationInTheStates(
        PlaceOfExecutionAtWithReexportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE records
    /// </summary>
    public Task<MetadataDto> PlaceOfExecutionAtWithReexportationInTheStatesMeta(
        PlaceOfExecutionAtWithReexportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task<PlaceOfExecutionAtWithReexportationInTheState> PlaceOfExecutionAtWithReexportationInTheState(
        PlaceOfExecutionAtWithReexportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one PLACE OF EXECUTION AT WITH REEXPORTATION IN THE STATE
    /// </summary>
    public Task UpdatePlaceOfExecutionAtWithReexportationInTheState(
        PlaceOfExecutionAtWithReexportationInTheStateWhereUniqueInput uniqueId,
        PlaceOfExecutionAtWithReexportationInTheStateUpdateInput updateDto
    );
}

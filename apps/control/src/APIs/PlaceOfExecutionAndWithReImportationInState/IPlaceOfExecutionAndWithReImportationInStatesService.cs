using Clre.APIs.Common;
using Clre.APIs.Dtos;

namespace Clre.APIs;

public interface IPlaceOfExecutionAndWithReImportationInStatesService
{
    /// <summary>
    /// Create one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public Task<PlaceOfExecutionAndWithReImportationInState> CreatePlaceOfExecutionAndWithReImportationInState(
        PlaceOfExecutionAndWithReImportationInStateCreateInput placeofexecutionandwithreimportationinstate
    );

    /// <summary>
    /// Delete one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public Task DeletePlaceOfExecutionAndWithReImportationInState(
        PlaceOfExecutionAndWithReImportationInStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATES
    /// </summary>
    public Task<
        List<PlaceOfExecutionAndWithReImportationInState>
    > PlaceOfExecutionAndWithReImportationInStates(
        PlaceOfExecutionAndWithReImportationInStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE records
    /// </summary>
    public Task<MetadataDto> PlaceOfExecutionAndWithReImportationInStatesMeta(
        PlaceOfExecutionAndWithReImportationInStateFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public Task<PlaceOfExecutionAndWithReImportationInState> PlaceOfExecutionAndWithReImportationInState(
        PlaceOfExecutionAndWithReImportationInStateWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one PLACE OF EXECUTION AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public Task UpdatePlaceOfExecutionAndWithReImportationInState(
        PlaceOfExecutionAndWithReImportationInStateWhereUniqueInput uniqueId,
        PlaceOfExecutionAndWithReImportationInStateUpdateInput updateDto
    );
}

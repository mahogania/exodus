using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IFinalExportFollowedByReimportationInTheStatesService
{
    /// <summary>
    ///     Create one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    public Task<FinalExportFollowedByReimportationInTheState> CreateFinalExportFollowedByReimportationInTheState(
        FinalExportFollowedByReimportationInTheStateCreateInput finalexportfollowedbyreimportationinthestate
    );

    /// <summary>
    ///     Delete one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    public Task DeleteFinalExportFollowedByReimportationInTheState(
        FinalExportFollowedByReimportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATES
    /// </summary>
    public Task<
        List<FinalExportFollowedByReimportationInTheState>
    > FinalExportFollowedByReimportationInTheStates(
        FinalExportFollowedByReimportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE records
    /// </summary>
    public Task<MetadataDto> FinalExportFollowedByReimportationInTheStatesMeta(
        FinalExportFollowedByReimportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    public Task<FinalExportFollowedByReimportationInTheState> FinalExportFollowedByReimportationInTheState(
        FinalExportFollowedByReimportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one FINAL EXPORT FOLLOWED BY REIMPORTATION IN THE STATE
    /// </summary>
    public Task UpdateFinalExportFollowedByReimportationInTheState(
        FinalExportFollowedByReimportationInTheStateWhereUniqueInput uniqueId,
        FinalExportFollowedByReimportationInTheStateUpdateInput updateDto
    );
}

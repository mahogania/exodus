using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IAtWithReExportationInTheStatesService
{
    /// <summary>
    ///     Create one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    public Task<AtWithReExportationInTheState> CreateAtWithReExportationInTheState(
        AtWithReExportationInTheStateCreateInput atwithreexportationinthestate
    );

    /// <summary>
    ///     Delete one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    public Task DeleteAtWithReExportationInTheState(
        AtWithReExportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many AT WITH RE-EXPORTATION IN THE STATES
    /// </summary>
    public Task<List<AtWithReExportationInTheState>> AtWithReExportationInTheStates(
        AtWithReExportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about AT WITH RE-EXPORTATION IN THE STATE records
    /// </summary>
    public Task<MetadataDto> AtWithReExportationInTheStatesMeta(
        AtWithReExportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    public Task<AtWithReExportationInTheState> AtWithReExportationInTheState(
        AtWithReExportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one AT WITH RE-EXPORTATION IN THE STATE
    /// </summary>
    public Task UpdateAtWithReExportationInTheState(
        AtWithReExportationInTheStateWhereUniqueInput uniqueId,
        AtWithReExportationInTheStateUpdateInput updateDto
    );
}

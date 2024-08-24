using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IReexportCarnetControlsService
{
    /// <summary>
    /// Create one Reexport Carnet Control
    /// </summary>
    public Task<ReexportCarnetControl> CreateReexportCarnetControl(
        ReexportCarnetControlCreateInput reexportcarnetcontrol
    );

    /// <summary>
    /// Delete one Reexport Carnet Control
    /// </summary>
    public Task DeleteReexportCarnetControl(ReexportCarnetControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Reexport Carnet Controls
    /// </summary>
    public Task<List<ReexportCarnetControl>> ReexportCarnetControls(
        ReexportCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Reexport Carnet Control records
    /// </summary>
    public Task<MetadataDto> ReexportCarnetControlsMeta(
        ReexportCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Reexport Carnet Control
    /// </summary>
    public Task<ReexportCarnetControl> ReexportCarnetControl(
        ReexportCarnetControlWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Reexport Carnet Control
    /// </summary>
    public Task UpdateReexportCarnetControl(
        ReexportCarnetControlWhereUniqueInput uniqueId,
        ReexportCarnetControlUpdateInput updateDto
    );
}

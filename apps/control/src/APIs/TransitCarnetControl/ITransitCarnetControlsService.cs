using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ITransitCarnetControlsService
{
    /// <summary>
    /// Create one Transit Carnet Control
    /// </summary>
    public Task<TransitCarnetControl> CreateTransitCarnetControl(
        TransitCarnetControlCreateInput transitcarnetcontrol
    );

    /// <summary>
    /// Delete one Transit Carnet Control
    /// </summary>
    public Task DeleteTransitCarnetControl(TransitCarnetControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Transit Carnet Controls
    /// </summary>
    public Task<List<TransitCarnetControl>> TransitCarnetControls(
        TransitCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Transit Carnet Control records
    /// </summary>
    public Task<MetadataDto> TransitCarnetControlsMeta(
        TransitCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Transit Carnet Control
    /// </summary>
    public Task<TransitCarnetControl> TransitCarnetControl(
        TransitCarnetControlWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Transit Carnet Control
    /// </summary>
    public Task UpdateTransitCarnetControl(
        TransitCarnetControlWhereUniqueInput uniqueId,
        TransitCarnetControlUpdateInput updateDto
    );
}

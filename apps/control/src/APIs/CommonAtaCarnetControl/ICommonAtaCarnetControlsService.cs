using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonAtaCarnetControlsService
{
    /// <summary>
    /// Create one Common ATA Carnet Control
    /// </summary>
    public Task<CommonAtaCarnetControl> CreateCommonAtaCarnetControl(
        CommonAtaCarnetControlCreateInput commonatacarnetcontrol
    );

    /// <summary>
    /// Delete one Common ATA Carnet Control
    /// </summary>
    public Task DeleteCommonAtaCarnetControl(CommonAtaCarnetControlWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Common ATA Carnet Controls
    /// </summary>
    public Task<List<CommonAtaCarnetControl>> CommonAtaCarnetControls(
        CommonAtaCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Common ATA Carnet Control records
    /// </summary>
    public Task<MetadataDto> CommonAtaCarnetControlsMeta(
        CommonAtaCarnetControlFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Common ATA Carnet Control
    /// </summary>
    public Task<CommonAtaCarnetControl> CommonAtaCarnetControl(
        CommonAtaCarnetControlWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Common ATA Carnet Control
    /// </summary>
    public Task UpdateCommonAtaCarnetControl(
        CommonAtaCarnetControlWhereUniqueInput uniqueId,
        CommonAtaCarnetControlUpdateInput updateDto
    );
}

using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICommonAtaCarnetControlAltsService
{
    /// <summary>
    /// Create one Common ATA Carnet Control Alt
    /// </summary>
    public Task<CommonAtaCarnetControlAlt> CreateCommonAtaCarnetControlAlt(
        CommonAtaCarnetControlAltCreateInput commonatacarnetcontrolalt
    );

    /// <summary>
    /// Delete one Common ATA Carnet Control Alt
    /// </summary>
    public Task DeleteCommonAtaCarnetControlAlt(CommonAtaCarnetControlAltWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Common ATA Carnet Control Alts
    /// </summary>
    public Task<List<CommonAtaCarnetControlAlt>> CommonAtaCarnetControlAlts(
        CommonAtaCarnetControlAltFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Common ATA Carnet Control Alt records
    /// </summary>
    public Task<MetadataDto> CommonAtaCarnetControlAltsMeta(
        CommonAtaCarnetControlAltFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Common ATA Carnet Control Alt
    /// </summary>
    public Task<CommonAtaCarnetControlAlt> CommonAtaCarnetControlAlt(
        CommonAtaCarnetControlAltWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Common ATA Carnet Control Alt
    /// </summary>
    public Task UpdateCommonAtaCarnetControlAlt(
        CommonAtaCarnetControlAltWhereUniqueInput uniqueId,
        CommonAtaCarnetControlAltUpdateInput updateDto
    );
}

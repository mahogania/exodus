using Code.APIs.Common;
using Code.APIs.Dtos;

namespace Code.APIs;

public interface IShProfilsService
{
    /// <summary>
    /// Create one ShProfil
    /// </summary>
    public Task<ShProfil> CreateShProfil(ShProfilCreateInput shprofil);

    /// <summary>
    /// Delete one ShProfil
    /// </summary>
    public Task DeleteShProfil(ShProfilWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many ShProfils
    /// </summary>
    public Task<List<ShProfil>> ShProfils(ShProfilFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about ShProfil records
    /// </summary>
    public Task<MetadataDto> ShProfilsMeta(ShProfilFindManyArgs findManyArgs);

    /// <summary>
    /// Get one ShProfil
    /// </summary>
    public Task<ShProfil> ShProfil(ShProfilWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one ShProfil
    /// </summary>
    public Task UpdateShProfil(ShProfilWhereUniqueInput uniqueId, ShProfilUpdateInput updateDto);
}

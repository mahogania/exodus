using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IRawMaterialsService
{
    /// <summary>
    /// Create one Raw Material
    /// </summary>
    public Task<RawMaterial> CreateRawMaterial(RawMaterialCreateInput rawmaterial);

    /// <summary>
    /// Delete one Raw Material
    /// </summary>
    public Task DeleteRawMaterial(RawMaterialWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public Task<List<RawMaterial>> RawMaterials(RawMaterialFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Raw Material records
    /// </summary>
    public Task<MetadataDto> RawMaterialsMeta(RawMaterialFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Raw Material
    /// </summary>
    public Task<RawMaterial> RawMaterial(RawMaterialWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Raw Material
    /// </summary>
    public Task UpdateRawMaterial(
        RawMaterialWhereUniqueInput uniqueId,
        RawMaterialUpdateInput updateDto
    );

    /// <summary>
    /// Get a Article record for RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<Article> GetArticle(RawMaterialWhereUniqueInput uniqueId);
}

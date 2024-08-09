using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IRawMaterialOfTheDetailedDeclarationCustomsItemsService
{
    /// <summary>
    /// Create one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<RawMaterialOfTheDetailedDeclarationCustoms> CreateRawMaterialOfTheDetailedDeclarationCustoms(
        RawMaterialOfTheDetailedDeclarationCustomsCreateInput rawmaterialofthedetaileddeclarationcustoms
    );

    /// <summary>
    /// Delete one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task DeleteRawMaterialOfTheDetailedDeclarationCustoms(
        RawMaterialOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    public Task<
        List<RawMaterialOfTheDetailedDeclarationCustoms>
    > RawMaterialOfTheDetailedDeclarationCustomsItems(
        RawMaterialOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    public Task<MetadataDto> RawMaterialOfTheDetailedDeclarationCustomsItemsMeta(
        RawMaterialOfTheDetailedDeclarationCustomsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task<RawMaterialOfTheDetailedDeclarationCustoms> RawMaterialOfTheDetailedDeclarationCustoms(
        RawMaterialOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public Task UpdateRawMaterialOfTheDetailedDeclarationCustoms(
        RawMaterialOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        RawMaterialOfTheDetailedDeclarationCustomsUpdateInput updateDto
    );
}

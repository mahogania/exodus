using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IGoodsAndWithReImportationInStatesService
{
    /// <summary>
    ///     Create one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public Task<GoodsAndWithReImportationInState> CreateGoodsAndWithReImportationInState(
        GoodsAndWithReImportationInStateCreateInput goodsandwithreimportationinstate
    );

    /// <summary>
    ///     Delete one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public Task DeleteGoodsAndWithReImportationInState(
        GoodsAndWithReImportationInStateWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many GOODS AND WITH RE-IMPORTATION IN STATES
    /// </summary>
    public Task<List<GoodsAndWithReImportationInState>> GoodsAndWithReImportationInStates(
        GoodsAndWithReImportationInStateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about GOODS AND WITH RE-IMPORTATION IN STATE records
    /// </summary>
    public Task<MetadataDto> GoodsAndWithReImportationInStatesMeta(
        GoodsAndWithReImportationInStateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public Task<GoodsAndWithReImportationInState> GoodsAndWithReImportationInState(
        GoodsAndWithReImportationInStateWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one GOODS AND WITH RE-IMPORTATION IN STATE
    /// </summary>
    public Task UpdateGoodsAndWithReImportationInState(
        GoodsAndWithReImportationInStateWhereUniqueInput uniqueId,
        GoodsAndWithReImportationInStateUpdateInput updateDto
    );
}

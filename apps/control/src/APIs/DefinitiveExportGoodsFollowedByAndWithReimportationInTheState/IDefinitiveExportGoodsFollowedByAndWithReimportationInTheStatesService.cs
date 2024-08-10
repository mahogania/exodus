using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesService
{
    /// <summary>
    ///     Create one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    public Task<DefinitiveExportGoodsFollowedByAndWithReimportationInTheState>
        CreateDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
            DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateCreateInput
                definitiveexportgoodsfollowedbyandwithreimportationinthestate
        );

    /// <summary>
    ///     Delete one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    public Task DeleteDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATES
    /// </summary>
    public Task<
        List<DefinitiveExportGoodsFollowedByAndWithReimportationInTheState>
    > DefinitiveExportGoodsFollowedByAndWithReimportationInTheStates(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE records
    /// </summary>
    public Task<MetadataDto> DefinitiveExportGoodsFollowedByAndWithReimportationInTheStatesMeta(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    public Task<DefinitiveExportGoodsFollowedByAndWithReimportationInTheState>
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
            DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereUniqueInput uniqueId
        );

    /// <summary>
    ///     Update one DEFINITIVE EXPORT GOODS FOLLOWED BY AND WITH REIMPORTATION IN THE STATE
    /// </summary>
    public Task UpdateDefinitiveExportGoodsFollowedByAndWithReimportationInTheState(
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateWhereUniqueInput uniqueId,
        DefinitiveExportGoodsFollowedByAndWithReimportationInTheStateUpdateInput updateDto
    );
}

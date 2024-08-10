using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface ICustomsClearanceOfPostalGoodsItemsService
{
    /// <summary>
    ///     Create one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public Task<CustomsClearanceOfPostalGoods> CreateCustomsClearanceOfPostalGoods(
        CustomsClearanceOfPostalGoodsCreateInput customsclearanceofpostalgoods
    );

    /// <summary>
    ///     Delete one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public Task DeleteCustomsClearanceOfPostalGoods(
        CustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Find many CUSTOMS CLEARANCE OF POSTAL GOODSItems
    /// </summary>
    public Task<List<CustomsClearanceOfPostalGoods>> CustomsClearanceOfPostalGoodsItems(
        CustomsClearanceOfPostalGoodsFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Meta data about CUSTOMS CLEARANCE OF POSTAL GOODS records
    /// </summary>
    public Task<MetadataDto> CustomsClearanceOfPostalGoodsItemsMeta(
        CustomsClearanceOfPostalGoodsFindManyArgs findManyArgs
    );

    /// <summary>
    ///     Get one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public Task<CustomsClearanceOfPostalGoods> CustomsClearanceOfPostalGoods(
        CustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    );

    /// <summary>
    ///     Update one CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public Task UpdateCustomsClearanceOfPostalGoods(
        CustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId,
        CustomsClearanceOfPostalGoodsUpdateInput updateDto
    );
}

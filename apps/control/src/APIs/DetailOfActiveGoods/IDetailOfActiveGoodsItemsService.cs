using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDetailOfActiveGoodsItemsService
{
    /// <summary>
    /// Create one Detail of Active Goods
    /// </summary>
    public Task<DetailOfActiveGoods> CreateDetailOfActiveGoods(
        DetailOfActiveGoodsCreateInput detailofactivegoods
    );

    /// <summary>
    /// Delete one Detail of Active Goods
    /// </summary>
    public Task DeleteDetailOfActiveGoods(DetailOfActiveGoodsWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Details of Active Goods
    /// </summary>
    public Task<List<DetailOfActiveGoods>> DetailOfActiveGoodsItems(
        DetailOfActiveGoodsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about Detail of Active Goods records
    /// </summary>
    public Task<MetadataDto> DetailOfActiveGoodsItemsMeta(
        DetailOfActiveGoodsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one Detail of Active Goods
    /// </summary>
    public Task<DetailOfActiveGoods> DetailOfActiveGoods(
        DetailOfActiveGoodsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one Detail of Active Goods
    /// </summary>
    public Task UpdateDetailOfActiveGoods(
        DetailOfActiveGoodsWhereUniqueInput uniqueId,
        DetailOfActiveGoodsUpdateInput updateDto
    );

    /// <summary>
    /// Get a Common Active Goods Request record for Details of Active Goods
    /// </summary>
    public Task<CommonActiveGoodsRequest> GetCommonActiveGoodsRequest(
        DetailOfActiveGoodsWhereUniqueInput uniqueId
    );
}

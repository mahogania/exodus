using Control.APIs.Common;
using Control.APIs.Dtos;

namespace Control.APIs;

public interface IDetailsOfTheCustomsClearanceOfPostalGoodsItemsService
{
    /// <summary>
    /// Create one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public Task<DetailsOfTheCustomsClearanceOfPostalGoods> CreateDetailsOfTheCustomsClearanceOfPostalGoods(
        DetailsOfTheCustomsClearanceOfPostalGoodsCreateInput detailsofthecustomsclearanceofpostalgoods
    );

    /// <summary>
    /// Delete one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public Task DeleteDetailsOfTheCustomsClearanceOfPostalGoods(
        DetailsOfTheCustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Find many DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODSItems
    /// </summary>
    public Task<
        List<DetailsOfTheCustomsClearanceOfPostalGoods>
    > DetailsOfTheCustomsClearanceOfPostalGoodsItems(
        DetailsOfTheCustomsClearanceOfPostalGoodsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Meta data about DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS records
    /// </summary>
    public Task<MetadataDto> DetailsOfTheCustomsClearanceOfPostalGoodsItemsMeta(
        DetailsOfTheCustomsClearanceOfPostalGoodsFindManyArgs findManyArgs
    );

    /// <summary>
    /// Get one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public Task<DetailsOfTheCustomsClearanceOfPostalGoods> DetailsOfTheCustomsClearanceOfPostalGoods(
        DetailsOfTheCustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId
    );

    /// <summary>
    /// Update one DETAILS OF THE CUSTOMS CLEARANCE OF POSTAL GOODS
    /// </summary>
    public Task UpdateDetailsOfTheCustomsClearanceOfPostalGoods(
        DetailsOfTheCustomsClearanceOfPostalGoodsWhereUniqueInput uniqueId,
        DetailsOfTheCustomsClearanceOfPostalGoodsUpdateInput updateDto
    );
}

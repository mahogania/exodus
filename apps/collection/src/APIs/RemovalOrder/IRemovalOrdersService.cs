using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IRemovalOrdersService
{
    /// <summary>
    ///     Create one REMOVAL ORDER
    /// </summary>
    public Task<RemovalOrder> CreateRemovalOrder(RemovalOrderCreateInput removalorder);

    /// <summary>
    ///     Delete one REMOVAL ORDER
    /// </summary>
    public Task DeleteRemovalOrder(RemovalOrderWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many REMOVAL ORDERS
    /// </summary>
    public Task<List<RemovalOrder>> RemovalOrders(RemovalOrderFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about REMOVAL ORDER records
    /// </summary>
    public Task<MetadataDto> RemovalOrdersMeta(RemovalOrderFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one REMOVAL ORDER
    /// </summary>
    public Task<RemovalOrder> RemovalOrder(RemovalOrderWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one REMOVAL ORDER
    /// </summary>
    public Task UpdateRemovalOrder(
        RemovalOrderWhereUniqueInput uniqueId,
        RemovalOrderUpdateInput updateDto
    );
}

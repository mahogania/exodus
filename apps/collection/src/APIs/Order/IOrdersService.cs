using Collection.APIs.Common;
using Collection.APIs.Dtos;

namespace Collection.APIs;

public interface IOrdersService
{
    /// <summary>
    ///     Create one ORDER
    /// </summary>
    public Task<Order> CreateOrder(OrderCreateInput order);

    /// <summary>
    ///     Delete one ORDER
    /// </summary>
    public Task DeleteOrder(OrderWhereUniqueInput uniqueId);

    /// <summary>
    ///     Find many ORDERS
    /// </summary>
    public Task<List<Order>> Orders(OrderFindManyArgs findManyArgs);

    /// <summary>
    ///     Meta data about ORDER records
    /// </summary>
    public Task<MetadataDto> OrdersMeta(OrderFindManyArgs findManyArgs);

    /// <summary>
    ///     Get one ORDER
    /// </summary>
    public Task<Order> Order(OrderWhereUniqueInput uniqueId);

    /// <summary>
    ///     Update one ORDER
    /// </summary>
    public Task UpdateOrder(OrderWhereUniqueInput uniqueId, OrderUpdateInput updateDto);
}

using Collection.Infrastructure;

namespace Collection.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(CollectionDbContext context)
        : base(context)
    {
    }
}

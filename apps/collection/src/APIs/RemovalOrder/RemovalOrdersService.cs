using Collection.Infrastructure;

namespace Collection.APIs;

public class RemovalOrdersService : RemovalOrdersServiceBase
{
    public RemovalOrdersService(CollectionDbContext context)
        : base(context) { }
}

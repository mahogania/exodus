using Collection.Infrastructure;

namespace Collection.APIs;

public class OthersItemsService : OthersItemsServiceBase
{
    public OthersItemsService(CollectionDbContext context)
        : base(context) { }
}

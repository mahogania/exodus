using Collection.Infrastructure;

namespace Collection.APIs;

public class CollectionsService : CollectionsServiceBase
{
    public CollectionsService(CollectionDbContext context)
        : base(context)
    {
    }
}

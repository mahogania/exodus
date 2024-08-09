using Collection.Infrastructure;

namespace Collection.APIs;

public class FineRequestsService : FineRequestsServiceBase
{
    public FineRequestsService(CollectionDbContext context)
        : base(context) { }
}

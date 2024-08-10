using Collection.Infrastructure;

namespace Collection.APIs;

public class VariousRequestsService : VariousRequestsServiceBase
{
    public VariousRequestsService(CollectionDbContext context)
        : base(context)
    {
    }
}

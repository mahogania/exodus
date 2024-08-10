using Collection.Infrastructure;

namespace Collection.APIs;

public class FineRequestHistoriesService : FineRequestHistoriesServiceBase
{
    public FineRequestHistoriesService(CollectionDbContext context)
        : base(context)
    {
    }
}

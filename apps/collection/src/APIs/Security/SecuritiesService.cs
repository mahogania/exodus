using Collection.Infrastructure;

namespace Collection.APIs;

public class SecuritiesService : SecuritiesServiceBase
{
    public SecuritiesService(CollectionDbContext context)
        : base(context)
    {
    }
}

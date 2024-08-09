using Collection.Infrastructure;

namespace Collection.APIs;

public class DistributionsService : DistributionsServiceBase
{
    public DistributionsService(CollectionDbContext context)
        : base(context) { }
}

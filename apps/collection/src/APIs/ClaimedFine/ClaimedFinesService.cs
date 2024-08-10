using Collection.Infrastructure;

namespace Collection.APIs;

public class ClaimedFinesService : ClaimedFinesServiceBase
{
    public ClaimedFinesService(CollectionDbContext context)
        : base(context)
    {
    }
}

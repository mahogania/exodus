using Collection.Infrastructure;

namespace Collection.APIs;

public class FineCancellationRequestsService : FineCancellationRequestsServiceBase
{
    public FineCancellationRequestsService(CollectionDbContext context)
        : base(context)
    {
    }
}

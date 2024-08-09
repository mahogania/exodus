using Collection.Infrastructure;

namespace Collection.APIs;

public class RefundRequestsService : RefundRequestsServiceBase
{
    public RefundRequestsService(CollectionDbContext context)
        : base(context) { }
}

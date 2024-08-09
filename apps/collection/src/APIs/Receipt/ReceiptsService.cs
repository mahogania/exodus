using Collection.Infrastructure;

namespace Collection.APIs;

public class ReceiptsService : ReceiptsServiceBase
{
    public ReceiptsService(CollectionDbContext context)
        : base(context) { }
}

using Collection.Infrastructure;

namespace Collection.APIs;

public class FinesService : FinesServiceBase
{
    public FinesService(CollectionDbContext context)
        : base(context) { }
}

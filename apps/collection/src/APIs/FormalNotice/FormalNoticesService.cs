using Collection.Infrastructure;

namespace Collection.APIs;

public class FormalNoticesService : FormalNoticesServiceBase
{
    public FormalNoticesService(CollectionDbContext context)
        : base(context) { }
}

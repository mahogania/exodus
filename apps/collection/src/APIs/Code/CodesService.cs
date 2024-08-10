using Collection.Infrastructure;

namespace Collection.APIs;

public class CodesService : CodesServiceBase
{
    public CodesService(CollectionDbContext context)
        : base(context)
    {
    }
}

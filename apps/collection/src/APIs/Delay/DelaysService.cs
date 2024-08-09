using Collection.Infrastructure;

namespace Collection.APIs;

public class DelaysService : DelaysServiceBase
{
    public DelaysService(CollectionDbContext context)
        : base(context) { }
}

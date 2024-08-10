using Collection.Infrastructure;

namespace Collection.APIs;

public class ReceptionsService : ReceptionsServiceBase
{
    public ReceptionsService(CollectionDbContext context)
        : base(context)
    {
    }
}

using Collection.Infrastructure;

namespace Collection.APIs;

public class ManagementsService : ManagementsServiceBase
{
    public ManagementsService(CollectionDbContext context)
        : base(context)
    {
    }
}

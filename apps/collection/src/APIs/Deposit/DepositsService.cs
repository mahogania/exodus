using Collection.Infrastructure;

namespace Collection.APIs;

public class DepositsService : DepositsServiceBase
{
    public DepositsService(CollectionDbContext context)
        : base(context)
    {
    }
}

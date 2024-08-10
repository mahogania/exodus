using Collection.Infrastructure;

namespace Collection.APIs;

public class AdjustmentsService : AdjustmentsServiceBase
{
    public AdjustmentsService(CollectionDbContext context)
        : base(context)
    {
    }
}

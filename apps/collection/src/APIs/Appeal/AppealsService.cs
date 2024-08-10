using Collection.Infrastructure;

namespace Collection.APIs;

public class AppealsService : AppealsServiceBase
{
    public AppealsService(CollectionDbContext context)
        : base(context)
    {
    }
}

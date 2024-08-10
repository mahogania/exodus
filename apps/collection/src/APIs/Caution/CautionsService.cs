using Collection.Infrastructure;

namespace Collection.APIs;

public class CautionsService : CautionsServiceBase
{
    public CautionsService(CollectionDbContext context)
        : base(context)
    {
    }
}

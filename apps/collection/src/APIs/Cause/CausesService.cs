using Collection.Infrastructure;

namespace Collection.APIs;

public class CausesService : CausesServiceBase
{
    public CausesService(CollectionDbContext context)
        : base(context) { }
}

using Collection.Infrastructure;

namespace Collection.APIs;

public class FineCausesService : FineCausesServiceBase
{
    public FineCausesService(CollectionDbContext context)
        : base(context) { }
}

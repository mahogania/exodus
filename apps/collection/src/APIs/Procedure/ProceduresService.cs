using Collection.Infrastructure;

namespace Collection.APIs;

public class ProceduresService : ProceduresServiceBase
{
    public ProceduresService(CollectionDbContext context)
        : base(context) { }
}

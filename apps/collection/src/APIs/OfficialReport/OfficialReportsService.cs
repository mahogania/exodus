using Collection.Infrastructure;

namespace Collection.APIs;

public class OfficialReportsService : OfficialReportsServiceBase
{
    public OfficialReportsService(CollectionDbContext context)
        : base(context)
    {
    }
}

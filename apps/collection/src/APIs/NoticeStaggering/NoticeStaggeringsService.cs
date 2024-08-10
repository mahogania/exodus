using Collection.Infrastructure;

namespace Collection.APIs;

public class NoticeStaggeringsService : NoticeStaggeringsServiceBase
{
    public NoticeStaggeringsService(CollectionDbContext context)
        : base(context)
    {
    }
}

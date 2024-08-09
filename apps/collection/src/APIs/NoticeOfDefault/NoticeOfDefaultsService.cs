using Collection.Infrastructure;

namespace Collection.APIs;

public class NoticeOfDefaultsService : NoticeOfDefaultsServiceBase
{
    public NoticeOfDefaultsService(CollectionDbContext context)
        : base(context) { }
}

using Collection.Infrastructure;

namespace Collection.APIs;

public class NoticeTypesService : NoticeTypesServiceBase
{
    public NoticeTypesService(CollectionDbContext context)
        : base(context) { }
}

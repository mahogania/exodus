using Collection.Infrastructure;

namespace Collection.APIs;

public class NoticesService : NoticesServiceBase
{
    public NoticesService(CollectionDbContext context)
        : base(context) { }
}

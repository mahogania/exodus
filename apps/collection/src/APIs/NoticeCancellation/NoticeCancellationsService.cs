using Collection.Infrastructure;

namespace Collection.APIs;

public class NoticeCancellationsService : NoticeCancellationsServiceBase
{
    public NoticeCancellationsService(CollectionDbContext context)
        : base(context) { }
}

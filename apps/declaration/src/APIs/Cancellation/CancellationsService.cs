using Statement.Infrastructure;

namespace Statement.APIs;

public class CancellationsService : CancellationsServiceBase
{
    public CancellationsService(StatementDbContext context)
        : base(context) { }
}

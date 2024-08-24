using Control.Infrastructure;

namespace Control.APIs;

public class CancellationRequestsService : CancellationRequestsServiceBase
{
    public CancellationRequestsService(ControlDbContext context)
        : base(context) { }
}

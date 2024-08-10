using Control.Infrastructure;

namespace Control.APIs;

public class ForeignOperatorRequestsService : ForeignOperatorRequestsServiceBase
{
    public ForeignOperatorRequestsService(ControlDbContext context)
        : base(context)
    {
    }
}

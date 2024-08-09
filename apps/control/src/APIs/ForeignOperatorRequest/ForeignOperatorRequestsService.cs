using Clre.Infrastructure;

namespace Clre.APIs;

public class ForeignOperatorRequestsService : ForeignOperatorRequestsServiceBase
{
    public ForeignOperatorRequestsService(ClreDbContext context)
        : base(context) { }
}

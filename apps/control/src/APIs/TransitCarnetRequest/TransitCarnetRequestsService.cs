using Control.Infrastructure;

namespace Control.APIs;

public class TransitCarnetRequestsService : TransitCarnetRequestsServiceBase
{
    public TransitCarnetRequestsService(ControlDbContext context)
        : base(context) { }
}

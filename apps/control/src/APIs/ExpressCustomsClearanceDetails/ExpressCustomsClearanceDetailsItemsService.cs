using Control.Infrastructure;

namespace Control.APIs;

public class ExpressCustomsClearanceDetailsItemsService
    : ExpressCustomsClearanceDetailsItemsServiceBase
{
    public ExpressCustomsClearanceDetailsItemsService(ControlDbContext context)
        : base(context)
    {
    }
}

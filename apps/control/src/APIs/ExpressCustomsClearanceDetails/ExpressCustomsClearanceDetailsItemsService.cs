using Clre.Infrastructure;

namespace Clre.APIs;

public class ExpressCustomsClearanceDetailsItemsService
    : ExpressCustomsClearanceDetailsItemsServiceBase
{
    public ExpressCustomsClearanceDetailsItemsService(ClreDbContext context)
        : base(context) { }
}

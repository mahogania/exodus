using Control.Infrastructure;

namespace Control.APIs;

public class ExtendedPeriodCarnetRequestsService : ExtendedPeriodCarnetRequestsServiceBase
{
    public ExtendedPeriodCarnetRequestsService(ControlDbContext context)
        : base(context) { }
}

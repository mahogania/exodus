using Control.Infrastructure;

namespace Control.APIs;

public class ReexportCarnetRequestsService : ReexportCarnetRequestsServiceBase
{
    public ReexportCarnetRequestsService(ControlDbContext context)
        : base(context) { }
}

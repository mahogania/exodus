using Control.Infrastructure;

namespace Control.APIs;

public class CommonCarnetRequestsService : CommonCarnetRequestsServiceBase
{
    public CommonCarnetRequestsService(ControlDbContext context)
        : base(context) { }
}

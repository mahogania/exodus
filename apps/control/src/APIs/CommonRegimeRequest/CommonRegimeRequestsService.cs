using Control.Infrastructure;

namespace Control.APIs;

public class CommonRegimeRequestsService : CommonRegimeRequestsServiceBase
{
    public CommonRegimeRequestsService(ControlDbContext context)
        : base(context) { }
}

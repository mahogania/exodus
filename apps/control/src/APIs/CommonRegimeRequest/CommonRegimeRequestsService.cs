using Clre.Infrastructure;

namespace Clre.APIs;

public class CommonRegimeRequestsService : CommonRegimeRequestsServiceBase
{
    public CommonRegimeRequestsService(ClreDbContext context)
        : base(context) { }
}

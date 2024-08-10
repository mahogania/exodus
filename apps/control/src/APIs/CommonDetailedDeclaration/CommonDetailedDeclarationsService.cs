using Control.Infrastructure;

namespace Control.APIs;

public class CommonDetailedDeclarationsService : CommonDetailedDeclarationsServiceBase
{
    public CommonDetailedDeclarationsService(ControlDbContext context)
        : base(context)
    {
    }
}

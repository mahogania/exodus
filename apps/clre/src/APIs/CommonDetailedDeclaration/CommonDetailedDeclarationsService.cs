using Clre.Infrastructure;

namespace Clre.APIs;

public class CommonDetailedDeclarationsService : CommonDetailedDeclarationsServiceBase
{
    public CommonDetailedDeclarationsService(ClreDbContext context)
        : base(context) { }
}

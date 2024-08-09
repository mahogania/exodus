using Clre.Infrastructure;

namespace Clre.APIs;

public class CommonExpressClearancesService : CommonExpressClearancesServiceBase
{
    public CommonExpressClearancesService(ClreDbContext context)
        : base(context) { }
}

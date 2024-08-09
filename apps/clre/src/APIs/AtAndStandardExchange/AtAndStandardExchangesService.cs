using Clre.Infrastructure;

namespace Clre.APIs;

public class AtAndStandardExchangesService : AtAndStandardExchangesServiceBase
{
    public AtAndStandardExchangesService(ClreDbContext context)
        : base(context) { }
}

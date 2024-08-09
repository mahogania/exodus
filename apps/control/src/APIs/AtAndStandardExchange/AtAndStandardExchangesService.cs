using Control.Infrastructure;

namespace Control.APIs;

public class AtAndStandardExchangesService : AtAndStandardExchangesServiceBase
{
    public AtAndStandardExchangesService(ControlDbContext context)
        : base(context) { }
}

using Control.Infrastructure;

namespace Control.APIs;

public class PostalParcelSimplifiedClearancesService : PostalParcelSimplifiedClearancesServiceBase
{
    public PostalParcelSimplifiedClearancesService(ControlDbContext context)
        : base(context) { }
}

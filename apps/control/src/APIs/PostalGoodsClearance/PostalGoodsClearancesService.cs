using Control.Infrastructure;

namespace Control.APIs;

public class PostalGoodsClearancesService : PostalGoodsClearancesServiceBase
{
    public PostalGoodsClearancesService(ControlDbContext context)
        : base(context) { }
}

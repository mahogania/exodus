using Control.Infrastructure;

namespace Control.APIs;

public class GoodsImportedForPerfectingsService : GoodsImportedForPerfectingsServiceBase
{
    public GoodsImportedForPerfectingsService(ControlDbContext context)
        : base(context)
    {
    }
}

using Control.Infrastructure;

namespace Control.APIs;

public class ReimportedGoodsForPerfectingsService : ReimportedGoodsForPerfectingsServiceBase
{
    public ReimportedGoodsForPerfectingsService(ControlDbContext context)
        : base(context)
    {
    }
}

using Clre.Infrastructure;

namespace Clre.APIs;

public class ReimportedGoodsForPerfectingsService : ReimportedGoodsForPerfectingsServiceBase
{
    public ReimportedGoodsForPerfectingsService(ClreDbContext context)
        : base(context) { }
}

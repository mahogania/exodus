using Clre.Infrastructure;

namespace Clre.APIs;

public class GoodsImportedForPerfectingsService : GoodsImportedForPerfectingsServiceBase
{
    public GoodsImportedForPerfectingsService(ClreDbContext context)
        : base(context) { }
}

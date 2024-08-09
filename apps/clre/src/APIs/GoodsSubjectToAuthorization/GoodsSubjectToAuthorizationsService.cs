using Clre.Infrastructure;

namespace Clre.APIs;

public class GoodsSubjectToAuthorizationsService : GoodsSubjectToAuthorizationsServiceBase
{
    public GoodsSubjectToAuthorizationsService(ClreDbContext context)
        : base(context) { }
}

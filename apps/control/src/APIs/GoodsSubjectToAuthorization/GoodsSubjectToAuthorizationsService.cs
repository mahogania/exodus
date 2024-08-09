using Control.Infrastructure;

namespace Control.APIs;

public class GoodsSubjectToAuthorizationsService : GoodsSubjectToAuthorizationsServiceBase
{
    public GoodsSubjectToAuthorizationsService(ControlDbContext context)
        : base(context) { }
}

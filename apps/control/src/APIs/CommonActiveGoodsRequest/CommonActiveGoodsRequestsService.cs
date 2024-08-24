using Control.Infrastructure;

namespace Control.APIs;

public class CommonActiveGoodsRequestsService : CommonActiveGoodsRequestsServiceBase
{
    public CommonActiveGoodsRequestsService(ControlDbContext context)
        : base(context) { }
}

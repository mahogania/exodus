using Control.Infrastructure;

namespace Control.APIs;

public class DetailOfActiveGoodsItemsService : DetailOfActiveGoodsItemsServiceBase
{
    public DetailOfActiveGoodsItemsService(ControlDbContext context)
        : base(context) { }
}

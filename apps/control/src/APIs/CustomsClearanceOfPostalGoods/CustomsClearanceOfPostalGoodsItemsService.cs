using Control.Infrastructure;

namespace Control.APIs;

public class CustomsClearanceOfPostalGoodsItemsService
    : CustomsClearanceOfPostalGoodsItemsServiceBase
{
    public CustomsClearanceOfPostalGoodsItemsService(ControlDbContext context)
        : base(context)
    {
    }
}

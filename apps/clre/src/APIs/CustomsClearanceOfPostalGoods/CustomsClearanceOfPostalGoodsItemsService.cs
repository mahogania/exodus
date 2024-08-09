using Clre.Infrastructure;

namespace Clre.APIs;

public class CustomsClearanceOfPostalGoodsItemsService
    : CustomsClearanceOfPostalGoodsItemsServiceBase
{
    public CustomsClearanceOfPostalGoodsItemsService(ClreDbContext context)
        : base(context) { }
}

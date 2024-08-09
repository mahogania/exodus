using Clre.Infrastructure;

namespace Clre.APIs;

public class ExportedAndForImprovementGoodsItemsService
    : ExportedAndForImprovementGoodsItemsServiceBase
{
    public ExportedAndForImprovementGoodsItemsService(ClreDbContext context)
        : base(context) { }
}

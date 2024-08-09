using Control.Infrastructure;

namespace Control.APIs;

public class ExportedAndForImprovementGoodsItemsService
    : ExportedAndForImprovementGoodsItemsServiceBase
{
    public ExportedAndForImprovementGoodsItemsService(ControlDbContext context)
        : base(context) { }
}

using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ExportedAndForImprovementGoodsItemsController
    : ExportedAndForImprovementGoodsItemsControllerBase
{
    public ExportedAndForImprovementGoodsItemsController(
        IExportedAndForImprovementGoodsItemsService service
    )
        : base(service) { }
}

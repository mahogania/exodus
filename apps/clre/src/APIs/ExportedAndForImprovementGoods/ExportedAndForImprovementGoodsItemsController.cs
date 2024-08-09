using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ExportedAndForImprovementGoodsItemsController
    : ExportedAndForImprovementGoodsItemsControllerBase
{
    public ExportedAndForImprovementGoodsItemsController(
        IExportedAndForImprovementGoodsItemsService service
    )
        : base(service) { }
}

using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ExportedOrToBeExportedGoodsInformationsController
    : ExportedOrToBeExportedGoodsInformationsControllerBase
{
    public ExportedOrToBeExportedGoodsInformationsController(
        IExportedOrToBeExportedGoodsInformationsService service
    )
        : base(service) { }
}

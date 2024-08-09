using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ExportedOrToBeExportedGoodsInformationsController
    : ExportedOrToBeExportedGoodsInformationsControllerBase
{
    public ExportedOrToBeExportedGoodsInformationsController(
        IExportedOrToBeExportedGoodsInformationsService service
    )
        : base(service) { }
}

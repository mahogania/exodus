using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class ImportedGoodsInformationsController : ImportedGoodsInformationsControllerBase
{
    public ImportedGoodsInformationsController(IImportedGoodsInformationsService service)
        : base(service)
    {
    }
}

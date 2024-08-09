using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class ImportedGoodsInformationsController : ImportedGoodsInformationsControllerBase
{
    public ImportedGoodsInformationsController(IImportedGoodsInformationsService service)
        : base(service) { }
}

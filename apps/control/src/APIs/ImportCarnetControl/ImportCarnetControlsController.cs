using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ImportCarnetControlsController : ImportCarnetControlsControllerBase
{
    public ImportCarnetControlsController(IImportCarnetControlsService service)
        : base(service) { }
}

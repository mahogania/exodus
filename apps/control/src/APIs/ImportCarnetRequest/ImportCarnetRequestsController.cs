using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ImportCarnetRequestsController : ImportCarnetRequestsControllerBase
{
    public ImportCarnetRequestsController(IImportCarnetRequestsService service)
        : base(service) { }
}

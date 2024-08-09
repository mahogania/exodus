using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class DirectImportationExportationsController : DirectImportationExportationsControllerBase
{
    public DirectImportationExportationsController(IDirectImportationExportationsService service)
        : base(service) { }
}

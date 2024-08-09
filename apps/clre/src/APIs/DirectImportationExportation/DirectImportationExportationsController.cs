using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DirectImportationExportationsController : DirectImportationExportationsControllerBase
{
    public DirectImportationExportationsController(IDirectImportationExportationsService service)
        : base(service) { }
}

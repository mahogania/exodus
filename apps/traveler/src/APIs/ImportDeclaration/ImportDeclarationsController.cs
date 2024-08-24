using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class ImportDeclarationsController : ImportDeclarationsControllerBase
{
    public ImportDeclarationsController(IImportDeclarationsService service)
        : base(service) { }
}

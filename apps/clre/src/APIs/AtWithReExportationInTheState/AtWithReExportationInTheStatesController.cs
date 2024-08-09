using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class AtWithReExportationInTheStatesController : AtWithReExportationInTheStatesControllerBase
{
    public AtWithReExportationInTheStatesController(IAtWithReExportationInTheStatesService service)
        : base(service) { }
}

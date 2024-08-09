using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class AtWithReExportationInTheStatesController : AtWithReExportationInTheStatesControllerBase
{
    public AtWithReExportationInTheStatesController(IAtWithReExportationInTheStatesService service)
        : base(service) { }
}

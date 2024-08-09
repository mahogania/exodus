using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class MacSuiteAtWithReexportationInTheStatesController
    : MacSuiteAtWithReexportationInTheStatesControllerBase
{
    public MacSuiteAtWithReexportationInTheStatesController(
        IMacSuiteAtWithReexportationInTheStatesService service
    )
        : base(service) { }
}

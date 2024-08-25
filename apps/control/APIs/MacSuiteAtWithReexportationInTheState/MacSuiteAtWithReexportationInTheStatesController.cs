using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class MacSuiteAtWithReexportationInTheStatesController
    : MacSuiteAtWithReexportationInTheStatesControllerBase
{
    public MacSuiteAtWithReexportationInTheStatesController(
        IMacSuiteAtWithReexportationInTheStatesService service
    )
        : base(service)
    {
    }
}

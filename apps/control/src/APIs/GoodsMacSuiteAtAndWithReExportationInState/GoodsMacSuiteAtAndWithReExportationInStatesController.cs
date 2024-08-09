using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class GoodsMacSuiteAtAndWithReExportationInStatesController
    : GoodsMacSuiteAtAndWithReExportationInStatesControllerBase
{
    public GoodsMacSuiteAtAndWithReExportationInStatesController(
        IGoodsMacSuiteAtAndWithReExportationInStatesService service
    )
        : base(service) { }
}

using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class GoodsMacSuiteAtAndWithReExportationInStatesController
    : GoodsMacSuiteAtAndWithReExportationInStatesControllerBase
{
    public GoodsMacSuiteAtAndWithReExportationInStatesController(
        IGoodsMacSuiteAtAndWithReExportationInStatesService service
    )
        : base(service) { }
}

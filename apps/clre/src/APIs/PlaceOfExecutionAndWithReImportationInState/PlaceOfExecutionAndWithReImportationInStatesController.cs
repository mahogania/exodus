using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class PlaceOfExecutionAndWithReImportationInStatesController
    : PlaceOfExecutionAndWithReImportationInStatesControllerBase
{
    public PlaceOfExecutionAndWithReImportationInStatesController(
        IPlaceOfExecutionAndWithReImportationInStatesService service
    )
        : base(service) { }
}

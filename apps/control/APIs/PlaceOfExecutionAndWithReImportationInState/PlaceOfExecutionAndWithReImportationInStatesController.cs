using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class PlaceOfExecutionAndWithReImportationInStatesController
    : PlaceOfExecutionAndWithReImportationInStatesControllerBase
{
    public PlaceOfExecutionAndWithReImportationInStatesController(
        IPlaceOfExecutionAndWithReImportationInStatesService service
    )
        : base(service)
    {
    }
}

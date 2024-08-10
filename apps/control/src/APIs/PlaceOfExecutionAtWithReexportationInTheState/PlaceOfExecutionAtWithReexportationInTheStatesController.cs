using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class PlaceOfExecutionAtWithReexportationInTheStatesController
    : PlaceOfExecutionAtWithReexportationInTheStatesControllerBase
{
    public PlaceOfExecutionAtWithReexportationInTheStatesController(
        IPlaceOfExecutionAtWithReexportationInTheStatesService service
    )
        : base(service)
    {
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class PlaceOfExecutionAtWithReexportationInTheStatesController
    : PlaceOfExecutionAtWithReexportationInTheStatesControllerBase
{
    public PlaceOfExecutionAtWithReexportationInTheStatesController(
        IPlaceOfExecutionAtWithReexportationInTheStatesService service
    )
        : base(service) { }
}

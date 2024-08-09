using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class MaterialsAtWithReexportationInTheStatesController
    : MaterialsAtWithReexportationInTheStatesControllerBase
{
    public MaterialsAtWithReexportationInTheStatesController(
        IMaterialsAtWithReexportationInTheStatesService service
    )
        : base(service) { }
}

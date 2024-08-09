using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class MaterialsAtWithReexportationInTheStatesController
    : MaterialsAtWithReexportationInTheStatesControllerBase
{
    public MaterialsAtWithReexportationInTheStatesController(
        IMaterialsAtWithReexportationInTheStatesService service
    )
        : base(service) { }
}

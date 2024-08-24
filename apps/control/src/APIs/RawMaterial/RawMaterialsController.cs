using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class RawMaterialsController : RawMaterialsControllerBase
{
    public RawMaterialsController(IRawMaterialsService service)
        : base(service) { }
}

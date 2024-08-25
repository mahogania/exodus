using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class CarnetControlsController : CarnetControlsControllerBase
{
    public CarnetControlsController(ICarnetControlsService service)
        : base(service) { }
}

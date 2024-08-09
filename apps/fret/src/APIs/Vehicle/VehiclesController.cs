using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[ApiController()]
public class VehiclesController : VehiclesControllerBase
{
    public VehiclesController(IVehiclesService service)
        : base(service) { }
}

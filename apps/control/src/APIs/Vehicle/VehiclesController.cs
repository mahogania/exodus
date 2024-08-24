using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class VehiclesController : VehiclesControllerBase
{
    public VehiclesController(IVehiclesService service)
        : base(service) { }
}

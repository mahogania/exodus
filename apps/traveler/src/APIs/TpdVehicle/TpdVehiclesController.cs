using Microsoft.AspNetCore.Mvc;

namespace Traveler.APIs;

[ApiController()]
public class TpdVehiclesController : TpdVehiclesControllerBase
{
    public TpdVehiclesController(ITpdVehiclesService service)
        : base(service) { }
}

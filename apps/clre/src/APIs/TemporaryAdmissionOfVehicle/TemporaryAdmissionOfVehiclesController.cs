using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class TemporaryAdmissionOfVehiclesController : TemporaryAdmissionOfVehiclesControllerBase
{
    public TemporaryAdmissionOfVehiclesController(ITemporaryAdmissionOfVehiclesService service)
        : base(service) { }
}

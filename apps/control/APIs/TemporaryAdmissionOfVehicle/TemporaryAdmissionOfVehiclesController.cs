using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class TemporaryAdmissionOfVehiclesController : TemporaryAdmissionOfVehiclesControllerBase
{
    public TemporaryAdmissionOfVehiclesController(ITemporaryAdmissionOfVehiclesService service)
        : base(service)
    {
    }
}

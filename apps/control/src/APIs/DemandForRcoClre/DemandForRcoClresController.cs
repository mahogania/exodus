using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController]
public class DemandForRcoClresController : DemandForRcoClresControllerBase
{
    public DemandForRcoClresController(IDemandForRcoClresService service)
        : base(service)
    {
    }
}

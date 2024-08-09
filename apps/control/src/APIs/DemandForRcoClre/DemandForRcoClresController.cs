using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[ApiController()]
public class DemandForRcoClresController : DemandForRcoClresControllerBase
{
    public DemandForRcoClresController(IDemandForRcoClresService service)
        : base(service) { }
}

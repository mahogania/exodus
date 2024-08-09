using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class CodesController : CodesControllerBase
{
    public CodesController(ICodesService service)
        : base(service) { }
}

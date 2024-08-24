using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class RcoDemandsController : RcoDemandsControllerBase
{
    public RcoDemandsController(IRcoDemandsService service)
        : base(service) { }
}

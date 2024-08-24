using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class JournalsController : JournalsControllerBase
{
    public JournalsController(IJournalsService service)
        : base(service) { }
}

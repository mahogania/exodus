using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[ApiController()]
public class ValeurBoursieresController : ValeurBoursieresControllerBase
{
    public ValeurBoursieresController(IValeurBoursieresService service)
        : base(service) { }
}

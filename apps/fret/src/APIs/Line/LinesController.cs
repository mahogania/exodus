using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[ApiController()]
public class LinesController : LinesControllerBase
{
    public LinesController(ILinesService service)
        : base(service) { }
}

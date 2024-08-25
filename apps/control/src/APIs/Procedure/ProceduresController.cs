using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[ApiController()]
public class ProceduresController : ProceduresControllerBase
{
    public ProceduresController(IProceduresService service)
        : base(service) { }
}

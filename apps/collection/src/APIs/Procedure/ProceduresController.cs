using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class ProceduresController : ProceduresControllerBase
{
    public ProceduresController(IProceduresService service)
        : base(service) { }
}

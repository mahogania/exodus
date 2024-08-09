using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class CausesController : CausesControllerBase
{
    public CausesController(ICausesService service)
        : base(service) { }
}

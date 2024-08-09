using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class CautionsController : CautionsControllerBase
{
    public CautionsController(ICautionsService service)
        : base(service) { }
}

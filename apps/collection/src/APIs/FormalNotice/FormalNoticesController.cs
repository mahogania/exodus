using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController]
public class FormalNoticesController : FormalNoticesControllerBase
{
    public FormalNoticesController(IFormalNoticesService service)
        : base(service)
    {
    }
}
